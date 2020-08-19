using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

/// <summary>
/// 
/// </summary>
class ImageProcessor
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filenames"></param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, img_name =>
        {
            Bitmap image = new Bitmap(img_name);
            Rectangle rekt = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData bmpdata = image.LockBits(rekt, ImageLockMode.ReadWrite, image.PixelFormat);

            IntPtr ptr = bmpdata.Scan0;

            int bytes = Math.Abs(bmpdata.Stride) * image.Height;
            byte[] rgbValues = new byte[bytes];

            Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length; i += 1)
                rgbValues[i] = (byte)(255 - rgbValues[i]);
            
            Marshal.Copy(rgbValues, 0, ptr, bytes);

            image.UnlockBits(bmpdata);

            string file_name = Path.GetFileNameWithoutExtension(img_name);
            string file_extension = Path.GetExtension(img_name);
            image.Save($"{file_name}_inverse{file_extension}");
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filenames"></param>
    public static void Grayscale(string[] filenames)
    {
        Parallel.ForEach(filenames, img_name =>
        {
            Bitmap image = new Bitmap(img_name);
            Rectangle rekt = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData bmpdata = image.LockBits(rekt, ImageLockMode.ReadWrite, image.PixelFormat);

            IntPtr ptr = bmpdata.Scan0;

            int bytes = Math.Abs(bmpdata.Stride) * image.Height;
            byte[] rgbValues = new byte[bytes];

            Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length - 2; i += 3)
            {
                byte grayscale = (byte)(rgbValues[i] * 0.21 + 0.71 * rgbValues[i + 1] + 0.071 * rgbValues[i + 2]);
                rgbValues[i] = rgbValues[i + 1] = rgbValues[i + 2] = grayscale;
            }
            
            Marshal.Copy(rgbValues, 0, ptr, bytes);

            image.UnlockBits(bmpdata);

            string file_name = Path.GetFileNameWithoutExtension(img_name);
            string file_extension = Path.GetExtension(img_name);
            image.Save($"{file_name}_grayscale{file_extension}");
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filenames"></param>
    /// <param name="threshold"></param>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        Parallel.ForEach(filenames, img_name =>
        {
            double total; 
            Bitmap image = new Bitmap(img_name);
            Rectangle rekt = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData bmpdata = image.LockBits(rekt, ImageLockMode.ReadWrite, image.PixelFormat);

            IntPtr ptr = bmpdata.Scan0;

            int bytes = Math.Abs(bmpdata.Stride) * image.Height;
            byte[] rgbValues = new byte[bytes];

            Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length - 2; i += 3)
            {
                total = rgbValues[i] + rgbValues[i + 1] + rgbValues[i + 2];
                if (total >= threshold)
                {
                    rgbValues[i] = 255;
                    rgbValues[i + 1] = 255;
                    rgbValues[i + 2] = 255;
                }
                else
                {
                    rgbValues[i] = 0;
                    rgbValues[i + 1] = 0;
                    rgbValues[i + 2] = 0;
                }
            }
            
            Marshal.Copy(rgbValues, 0, ptr, bytes);

            image.UnlockBits(bmpdata);

            string file_name = Path.GetFileNameWithoutExtension(img_name);
            string file_extension = Path.GetExtension(img_name);
            image.Save($"{file_name}_bw{file_extension}");
        });

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filenames"></param>
    /// <param name="height"></param>
    public static void Thumbnail(string[] filenames, int height)
    {
        Parallel.ForEach(filenames, img_name =>
        {
            using (Bitmap image = new Bitmap(img_name))
            {
                string file_name = Path.GetFileNameWithoutExtension(img_name);
                string file_extension = Path.GetExtension(img_name);

                int width = height * (image.Width / image.Height);
                image bmp = image.GetThumbnailImage(width, height, null, IntPtr.Zero);

                image.Save($"{file_name}_th{file_extension}");
            }
        });
    }
}
