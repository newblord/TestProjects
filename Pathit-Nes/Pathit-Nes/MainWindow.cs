namespace Pathit_Nes
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static async Task<MainWindow> Create()
        {
            var mainWindow = new MainWindow();

            await mainWindow.LoadRom().ConfigureAwait(false);

            return mainWindow;
        }

        private async Task LoadRom()
        {
            var cancellationToken = new CancellationToken();
            var bytes = await File.ReadAllBytesAsync(@"Super Mario Bros. 3.nes", cancellationToken).ConfigureAwait(false);

            foreach (var b in bytes.Take(10))
            {
                lbBytes.Items.Add(b);
            }
        }

        private async void btnLoadRom_Click(object sender, EventArgs e)
        {
            await LoadRom().ConfigureAwait(false);
        }
    }
}