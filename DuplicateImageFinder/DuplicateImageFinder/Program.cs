using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using Shipwreck.Phash;
using Shipwreck.Phash.Bitmaps;

namespace DuplicateImageFinder
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<string> files = Directory.GetFiles(@"C:\Users\Newblord\Desktop\TestImages"
                                                            , "*.*"
                                                            , SearchOption.AllDirectories)
                                                            .Where(x => x.ToLower().EndsWith(".jpg")
                                                                        || x.ToLower().EndsWith(".jpeg")
                                                                        || x.ToLower().EndsWith(".png")
                                                                        || x.ToLower().EndsWith(".gif"));
                                                                        //.OrderBy(x => int.Parse(Path.GetFileNameWithoutExtension(x).ToUpper().Replace("IMAGE","")));

            //HashAndCompareFiles(files); // original hashing method

            ComapreFilesWithPHash(files); // pHash hasing method
        }

        public static void HashAndCompareFiles(IEnumerable<string> files)
        {
            int i = 0;

            List<CustomFile> customFiles = new List<CustomFile>();

            foreach (var file in files)
            {
                Bitmap b = new Bitmap(file) { Tag = file };

                //var resizedImage = ResizeImage(b, 16, 16);

                //Bitmap grayscale = MakeGrayscale(resizedImage);

                //var fileHash = HashImage(grayscale);

                //string fileHash = Convert.ToBase64String(hash);

                var fileHash = GetHash(b);

                CustomFile newFile = new CustomFile()
                {
                    FilePath = file,
                    FileHash = fileHash,
                    OriginalHeight = b.Height,
                    OriginalWidth = b.Width
                };

                customFiles.Add(newFile);

                b.Dispose();
                //grayscale.Dispose();
                //resizedImage.Dispose();

                i++;
            }

            i = 1;

            List<CompareResult> results = new List<CompareResult>();

            while (customFiles.Count > 0)
            {
                var searchResults = customFiles.Where(x => x.FilePath != customFiles[0].FilePath && customFiles[0].FileHash.Zip(x.FileHash, (h, j) => h == j).Count(eq => eq) >= (256 * 0.9)).ToList();

                var result = new CompareResult()
                {
                    FileToKeep = customFiles[0],
                    FilesToDelete = searchResults
                };

                results.Add(result);

                customFiles.RemoveAt(0);

                foreach (var searchResult in searchResults)
                {
                    customFiles.Remove(searchResult);
                }
            }

            foreach (var result in results)
            {
                File.Copy(result.FileToKeep.FilePath, $@"C:\Users\Newblord\Desktop\TestImages\ProcessedFiles\Image{i}.JPG");

                for (int x = 0; x < result.FilesToDelete.Count; x++)
                {
                    File.Copy(result.FilesToDelete[x].FilePath, $@"C:\Users\Newblord\Desktop\TestImages\FilesDeleted\Image{i}_{x}.JPG");
                }

                i++;
            }
        }

        public static void ComapreFilesWithPHash(IEnumerable<string> files)
        {
            List<PHashFile> customFiles = new List<PHashFile>();

            foreach (var file in files)
            {
                var bitmap = (Bitmap)Image.FromFile(file);
                var resize = ResizeImage(bitmap, 128, 128);
                var hash = ImagePhash.ComputeDigest(resize.ToLuminanceImage());

                PHashFile newFile = new PHashFile()
                {
                    FilePath = file,
                    FileHash = hash,
                    OriginalHeight = bitmap.Height,
                    OriginalWidth = bitmap.Width
                };

                customFiles.Add(newFile);

                bitmap.Dispose();
            }

            //Parallel.ForEach(files, (file) =>
            //{
            //    var bitmap = (Bitmap)Image.FromFile(file);
            //    var resize = ResizeImage(bitmap, 128, 128);
            //    var hash = ImagePhash.ComputeDigest(resize.ToLuminanceImage());

            //    PHashFile newFile = new PHashFile()
            //    {
            //        FilePath = file,
            //        FileHash = hash,
            //        OriginalHeight = bitmap.Height,
            //        OriginalWidth = bitmap.Width
            //    };

            //    lock (customFiles)
            //    {
            //        customFiles.Add(newFile);
            //    }

            //    bitmap.Dispose();
            //});

            List<PHashResult> results = new List<PHashResult>();

            while (customFiles.Count > 0)
            {
                var searchResults = customFiles.Where(x => ImagePhash.GetCrossCorrelation(customFiles[0].FileHash, x.FileHash) >= .98)
                                                .OrderByDescending(x => x.OriginalHeight).OrderByDescending(x => x.OriginalWidth).ToList();

                var result = new PHashResult();
                result.FileToKeep = searchResults.Count > 0 ? searchResults[0] : customFiles[0];

                if (searchResults.Count > 0)
                    searchResults.RemoveAt(0);

                result.FilesToDelete = searchResults;

                results.Add(result);

                customFiles.Remove(result.FileToKeep);

                foreach (var searchResult in searchResults)
                {
                    customFiles.Remove(searchResult);
                }
            }

            int i = 1;

            foreach (var result in results)
            {
                File.Copy(result.FileToKeep.FilePath, $@"C:\Users\Newblord\Desktop\TestImages\ProcessedFiles\Image{i}.JPG");

                for (int x = 0; x < result.FilesToDelete.Count; x++)
                {
                    File.Copy(result.FilesToDelete[x].FilePath, $@"C:\Users\Newblord\Desktop\TestImages\FilesDeleted\Image{i}_{x}.JPG");
                }

                i++;
            }
        }

        public static Bitmap MakeGrayscale(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height) { Tag = original.Tag };

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                   new float[] {.3f, .3f, .3f, 0, 0},
                   new float[] {.59f, .59f, .59f, 0, 0},
                   new float[] {.11f, .11f, .11f, 0, 0},
                   new float[] {0, 0, 0, 1, 0},
                   new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                         0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();

            return newBitmap;
        }

        public static Bitmap ResizeImage(Bitmap imgToResize, int width, int height)
        {
            try
            {
                Bitmap b = new Bitmap(width, height);
                using (Graphics g = Graphics.FromImage((Image)b))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(imgToResize, 0, 0, width, height);
                }
                return b;
            }
            catch
            {
                Console.WriteLine("Bitmap could not be resized");
                return imgToResize;
            }
        }

        public static byte[] HashImage(Bitmap image)
        {
            var sha256 = SHA256.Create();

            var rect = new Rectangle(0, 0, image.Width, image.Height);
            var data = image.LockBits(rect, ImageLockMode.ReadOnly, image.PixelFormat);

            var dataPtr = data.Scan0;

            var totalBytes = (int)Math.Abs(data.Stride) * data.Height;
            var rawData = new byte[totalBytes];
            System.Runtime.InteropServices.Marshal.Copy(dataPtr, rawData, 0, totalBytes);

            image.UnlockBits(data);

            return sha256.ComputeHash(rawData);
        }

        public static List<bool> GetHash(Bitmap bmpSource)
        {
            List<bool> lResult = new List<bool>();
            //create new image with 16x16 pixel
            Bitmap bmpMin = new Bitmap(bmpSource, new Size(16, 16));
            for (int j = 0; j < bmpMin.Height; j++)
            {
                for (int i = 0; i < bmpMin.Width; i++)
                {
                    //reduce colors to true / false                
                    lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
                }
            }
            return lResult;
        }

        public static bool CompareBitmapsFast(Bitmap bmp1, Bitmap bmp2)
        {
            if (bmp1 == null || bmp2 == null)
                return false;
            if (object.Equals(bmp1, bmp2))
                return true;
            if (!bmp1.Size.Equals(bmp2.Size) || !bmp1.PixelFormat.Equals(bmp2.PixelFormat))
                return false;

            int bytes = bmp1.Width * bmp1.Height * (Image.GetPixelFormatSize(bmp1.PixelFormat) / 8);

            bool result = true;
            byte[] b1bytes = new byte[bytes];
            byte[] b2bytes = new byte[bytes];

            BitmapData bitmapData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width - 1, bmp1.Height - 1), ImageLockMode.ReadOnly, bmp1.PixelFormat);
            BitmapData bitmapData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width - 1, bmp2.Height - 1), ImageLockMode.ReadOnly, bmp2.PixelFormat);

            Marshal.Copy(bitmapData1.Scan0, b1bytes, 0, bytes);
            Marshal.Copy(bitmapData2.Scan0, b2bytes, 0, bytes);

            for (int n = 0; n <= bytes - 1; n++)
            {
                if (b1bytes[n] != b2bytes[n])
                {
                    result = false;
                    break;
                }
            }

            bmp1.UnlockBits(bitmapData1);
            bmp2.UnlockBits(bitmapData2);

            return result;
        }

        public class CustomFile
        {
            public string FilePath { get; set; }
            public List<bool> FileHash { get; set; }
            //public byte[] FileHash { get; set; }
            public int OriginalHeight { get; set; }
            public int OriginalWidth { get; set; }
        }

        public class CompareResult
        {
            public CustomFile FileToKeep { get; set; }
            public List<CustomFile> FilesToDelete { get; set; }
        }

        public class PHashFile
        {
            public string FilePath { get; set; }
            public Digest FileHash { get; set; }
            public int OriginalHeight { get; set; }
            public int OriginalWidth { get; set; }
        }

        public class PHashResult
        {
            public PHashFile FileToKeep { get; set; }
            public List<PHashFile> FilesToDelete { get; set; }
        }

    }
}
