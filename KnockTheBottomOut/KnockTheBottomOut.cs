using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace KnockTheBottomOut
{

   
    class KnockTheBottomOut
    {
        static void Main(string[] args)
        {

            IBitmapStreamProvider provider;

            //switch (args[1])
            //{
            //    case "path":
            //        provider = new BitmapFileStreamProvider();
            //        break;
            //    case "web":
            //        provider = new BitmapFileStreamProvider();
            //        break;
            //}


            provider = new BitmapFileStreamProvider(@"C:\Windows", "", "WordUp", "Etc");

            foreach (Bitmap bmp in provider.FileQueue)
            {
                Console.WriteLine(bmp.Height);
            }



        }
    }
}
