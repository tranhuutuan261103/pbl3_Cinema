using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_Cinema.MyFuncStatic
{
    internal class MyConvert
    {
        public static byte[] ConvertVideoToBytes(string path)
        {
            using (Stream video = File.OpenRead(path))
            {
                byte[] buffer = new byte[100000000];

                video.Read(buffer, 0, buffer.Length);

                return buffer;
            }
        }

        public static Image ConvertBinaryToImage(byte[] data)
        {
            if (data == null)
            {
                return null;
            }
            using (MemoryStream ms = new MemoryStream(data))
            {
                Image img = new Bitmap(ms);
                return img;
                //return Image.FromStream(ms);
            }
        }

        public static byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Image i = new Bitmap(img);
                i.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
