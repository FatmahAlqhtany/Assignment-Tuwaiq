using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp9
{
    class FileFormatForPNG.
    {
        const string fileName = @"C:\Users\win\Desktop\kkk.png";

        static void Main(string[] args)
        {
            DisplayValues();
        }

        public static void DisplayValues()
        {
            byte[] magicNumber;
            const string path = @"C:\Users\win\Desktop\kkk.png";
            const string pngMagic = "89-50-4E-47-0D-0A-1A-0A";
            using (BinaryReader reader = new BinaryReader(new FileStream(Convert.ToString(path), FileMode.Open)))
            {
                magicNumber = reader.ReadBytes(0x8);
                string magicNumberHex = BitConverter.ToString(magicNumber);
                if (magicNumberHex.Equals(pngMagic))
                {
                    Console.WriteLine(" Type is PNG");
                    byte[] ignore = reader.ReadBytes(0x8);
                    int width = Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(0x4)).Replace("-", ""), 16);
                    int height = Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(0x4)).Replace("-", ""), 16);
                    int depth = Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(0x1)).Replace("-", ""), 16);
                    int colorType = Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(0x1)).Replace("-", ""), 16);
                    int compressionMethod =
                        Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(0x1)).Replace("-", ""), 16);
                    int filterMethod =
                        Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(0x1)).Replace("-", ""), 16);
                    int interlaceMethod =
                        Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(0x1)).Replace("-", ""), 16);
                    int IDAT =
                        Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(0x4)).Replace("-", ""), 16);

                    Console.WriteLine($"width {width}");
                    Console.WriteLine($"height {height}");
                    Console.WriteLine($"depth {depth}");
                    Console.WriteLine($"color type {colorType}");
                    Console.WriteLine($"compression meth {compressionMethod}");
                    Console.WriteLine($"filter meth {filterMethod}");
                    Console.WriteLine($"Interlace method {interlaceMethod}");
                }
            }
        }
    }
}
