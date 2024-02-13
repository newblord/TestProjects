using System.Runtime.Intrinsics.X86;

namespace Pathit_Chip8
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            var chip8 = new Chip8(@"pong.ch8");
            chip8.LoadProgram().GetAwaiter().GetResult();
        }
    }

    public struct OpCodeData
    {
        public ushort OpCode;
        public ushort NNN;
        public byte NN, X, Y, N;
    }

    public class Chip8
    {
        // Constants for screen size
        const int ScreenWidth = 64, ScreenHeight = 32;

        // A buffer containing a bool for each pixel on the screen (Chip-8 was monochrome)
        bool[,] buffer = new bool[ScreenWidth, ScreenHeight];

        // Actions that the chip should invoke (draw will be called from inside Tick60Hz, beep whenever we need to beep).
        // These are passed in on the constuctor since they'll generally by implemented in some platform-specific way.
        Action<bool[,]> draw;
        Action<int> beep;

        // Chip-8 has 16x 8-bit registers (referred to as V) which we'll store as byte[16].
        // As with most things in this file, we'll use hex to refer to things, so these 
        // are V[0x0] to V[0xF]. The last register, V[F] is also used for special purposes
        // such as a carry and collision flag.
        byte[] V = new byte[16];

        // There are supposed to be two timers (Sound, Delay) but the easiest way for me to implement a beep
        // was with Console.Beep(frequency, duration) so rather than have a Sound timer that counts down
        // I just immediately start playing for the given duration. This might not be perfect (you can't
        // cancel an in-progress sound) but I suspect in reality it works for all games.
        byte Delay;

        // The address register (referred to as I) is 16-bit and is used store memory addresses such as
        // when rendering sprites.
        ushort I;

        // The program counter (where we're currently executing instructions from) is also 16-bit and
        // This starts at the location 0x200 (512) because the first 512 bytes were used by the interpreter.
        // We use 0x0 to 0x200 to store things like the built-in font data.
        ushort PC = 0x200;

        // The Chip-8 stack is only used to store program counter locations when jumping to subroutines.
        // We use an array that can store 16 addresses and a single byte to index into it. Whenever jumping to
        // a subroutine we will push the program counter (PC) to the stack (Stack[SP]) and increment SP
        // (the stack pointer). When we need to return, we will decrement SP and then read the address to return
        // to from Stack[SP].
        byte SP;
        ushort[] Stack = new ushort[16];

        // The original Chip-8 systems had 4K (0x1000) of addressable memory. 
        byte[] RAM = new byte[0x1000];

        // To enable fast lookups of functions to execute for each opcode, we use a dictionary.
        // Normally we use the first nibble (4 bits) of the two-byte instruction to decide what to do,
        // however there's a bunch of random instructions all lumped into the 0xF000 nibble so we have
        // an additional dictionary to look them up based on the second byte.
        Dictionary<byte, Action<OpCodeData>> opCodes;
        Dictionary<byte, Action<OpCodeData>> opCodesMisc;

        // One of the instructions is to generate a random number, so we'll need this.
        Random rnd = new Random();

        // We also need to keep track of which keys are currently held down. Chip-8 had a 16-key keyboard
        // much like a numeric pad with A-F around the edges:
        //    1   2   3   C
        //    4   5   6   D
        //    7   8   9   E
        //    A   0   B   F
        // We store these in a HashSet to allow easy checking of whether a key is down.
        HashSet<byte> pressedKeys = new HashSet<byte>();

        string romPath;

        byte[] romData;

        public Chip8(string romPath)
        {
            this.romPath = romPath;

            opCodes = new Dictionary<byte, Action<OpCodeData>>
            {
                { 0x0, ClearOrReturn }, // There are two instructions starting with a 0 nibble, didn't seem worth its own dictionary
	            //{ 0x1, Jump },
             //   { 0x2, CallSubroutine },
             //   { 0x3, SkipIfXEqual },
             //   { 0x4, SkipIfXNotEqual },
             //   { 0x5, SkipIfXEqualY },
             //   { 0x6, SetX },
             //   { 0x7, AddX },
             //   { 0x8, Arithmetic },
             //   { 0x9, SkipIfXNotEqualY },
             //   { 0xA, SetI },
             //   { 0xB, JumpWithOffset },
             //   { 0xC, Rnd },
             //   { 0xD, DrawSprite },
             //   { 0xE, SkipOnKey },
             //   { 0xF, Misc }, // This will do a lookup from the second dictionary
            };

            //opCodesMisc = new Dictionary<byte, Action<OpCodeData>>
            //{
            //    { 0x07, SetXToDelay },
            //    { 0x0A, WaitForKey },
            //    { 0x15, SetDelay },
            //    { 0x18, SetSound },
            //    { 0x1E, AddXToI },
            //    { 0x29, SetIForChar },
            //    { 0x33, BinaryCodedDecimal },
            //    { 0x55, SaveX },
            //    { 0x65, LoadX },
            //};
        }

        public async Task LoadProgram()
        {
            await LoadRom().ConfigureAwait(false);
            await RunRom().ConfigureAwait(false);
        }

        private async Task LoadRom()
        {
            romData = await File.ReadAllBytesAsync(romPath).ConfigureAwait(false);
            Array.Copy(romData, 0, RAM, 0x200, romData.Length);
        }

        private async Task RunRom()
        {
            for (int i = 0; i < romData.Length;)
            {
                var opCode = (ushort)(romData[i++] << 8 | romData[i++]); // Adds the next bytes together

                // Split data into the possible formats the instruction might need.
                // https://en.wikipedia.org/wiki/CHIP-8#Opcode_table
                var op = new OpCodeData()
                {
                    // We use bitwise-and with a mask to extract specific nibbles.
                    OpCode = opCode,
                    NNN = (ushort)(opCode & 0x0FFF),
                    NN = (byte)(opCode & 0x00FF),
                    N = (byte)(opCode & 0x000F),
                    X = (byte)((opCode & 0x0F00) >> 8), // We don't use the lower nibbles, bitshift right to get just the raw value
                    Y = (byte)((opCode & 0x00F0) >> 4), // Eg. we want 0x4 not 0x40
                };
            }
        }

        private void ClearOrReturn(OpCodeData opCode)
        {
            Array.Clear(buffer);
        }
    }
}