using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DuplicateRomFinder
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                foreach (var path in Directory.GetDirectories(fbd.SelectedPath))
                {
                    Console.WriteLine(path); // full path

                    Dictionary<string, Rom> files = new Dictionary<string, Rom>();

                    foreach (var fPath in Directory.GetFiles(path))
                    {
                        Console.WriteLine(Path.GetFileName(fPath));
                        string fullFilename = System.IO.Path.GetFileNameWithoutExtension(fPath);
                        string extension = Path.GetExtension(fPath);

                        string[] fileNameSplit = fullFilename.Split('(');
                        string filename = $"{fileNameSplit[0].Trim()}{extension}";
                        fullFilename = $"{fullFilename}{extension}";
                        string[] countries = new string[1];

                        if (fullFilename.Contains("#"))
                        {
                            filename = $"{fullFilename.Split('#')[0].Trim()}{extension}";
                        }

                        if (fileNameSplit.Length > 1)
                        {
                            countries = fileNameSplit[1].Split(')')[0].ToLower().Split(',');
                        }
                        else
                        {
                            countries[0] = "usa";
                        }

                        if (countries.Where(x => x == "japan").FirstOrDefault() != null)
                        {
                            File.Delete(fPath);
                        }
                        else if (files.ContainsKey(filename))
                        {
                            Rom rom = files.Where(x => x.Key == filename).First().Value;

                            if (rom.Countries.Contains("usa") && rom.OriginalFileName.Contains("(Beta)") && countries.Contains("usa") && !fullFilename.Contains("(Beta)"))
                            {
                                files.Remove(filename);
                                File.Delete(rom.FilePath);
                                Rom newRom = new Rom() { FilePath = fPath, NewFilename = filename, OriginalFileName = fullFilename, Countries = countries };
                                files.Add(filename, newRom);
                            }
                            else if (rom.Countries.Contains("usa") && !rom.OriginalFileName.Contains("(Beta)") && countries.Contains("usa") && fullFilename.Contains("(Beta)"))
                            {
                                File.Delete(fPath);
                            }
                            else if (Enumerable.SequenceEqual(rom.Countries, countries) && rom.OriginalFileName.Contains("(Beta)") && !fullFilename.Contains("(Beta)"))
                            {
                                files.Remove(filename);
                                File.Delete(rom.FilePath);
                                Rom newRom = new Rom() { FilePath = fPath, NewFilename = filename, OriginalFileName = fullFilename, Countries = countries };
                                files.Add(filename, newRom);
                            }
                            else if (Enumerable.SequenceEqual(rom.Countries,countries) && !rom.OriginalFileName.Contains("(Beta)") && fullFilename.Contains("(Beta)"))
                            {
                                File.Delete(fPath);
                            }
                            else if (rom.Countries.Contains("usa") && countries.Contains("usa"))
                            {
                                File.Delete(fPath);
                            }
                            else if (rom.Countries.Contains("usa") && !countries.Contains("usa"))
                            {
                                File.Delete(fPath);
                            }
                            else if (!rom.Countries.Contains("usa") && countries.Contains("usa"))
                            {
                                files.Remove(filename);
                                File.Delete(rom.FilePath);
                                Rom newRom = new Rom() { FilePath = fPath, NewFilename = filename, OriginalFileName = fullFilename, Countries = countries };
                                files.Add(filename, newRom);
                            }
                            else if(!Enumerable.SequenceEqual(rom.Countries, countries))
                            {
                                File.Delete(fPath);
                            }
                            else if (Enumerable.SequenceEqual(rom.Countries, countries))
                            {
                                if(rom.OriginalFileName.Length > fullFilename.Length)
                                {
                                    files.Remove(filename);
                                    File.Delete(rom.FilePath);
                                    Rom newRom = new Rom() { FilePath = fPath, NewFilename = filename, OriginalFileName = fullFilename, Countries = countries };
                                    files.Add(filename, newRom);
                                }
                                else
                                {
                                    File.Delete(fPath);
                                }
                            }
                        }
                        else
                        {
                            Rom rom = new Rom() { FilePath = fPath, NewFilename = filename, OriginalFileName = fullFilename, Countries = countries };
                            files.Add(filename, rom);
                        }
                    }

                    foreach (var file in files)
                    {
                        string newFilePath = $"{file.Value.FilePath.Replace(file.Value.OriginalFileName, "")}{file.Value.NewFilename}";
                        if (!File.Exists(newFilePath))
                        {
                            File.Move(file.Value.FilePath, newFilePath);
                        }
                    }
                }
            }

            Console.ReadLine();
        }

        public class Rom
        {
            public string FilePath { get; set; }
            public string NewFilename { get; set; }
            public string OriginalFileName { get; set; }
            public string[] Countries { get; set; }
        }
    }
}
