using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;


namespace KnockTheBottomOut
{
    public class BitmapFileStreamProvider : IBitmapStreamProvider
    {
        public IEnumerable<Bitmap> FileQueue
        {
            get
            {
                return GetNextFile();
            }
        }

        public BitmapFileStreamProvider(string inputpath, string outputpath = "")
        {

        }

        public BitmapFileStreamProvider(string inputpath, string outputpath = "", string prepend = "", string append = "")
        {
        }


        private IEnumerable<Bitmap> GetNextFile()
        {
            IEnumerable<string> fileLocations = this.Search("C:\\Users\\eroper\\Desktop"); // load list of file uri's or paths here, recursively if needed

            foreach (string location in fileLocations)
            {
                var bitmap = new Bitmap("C:\\Users\\eroper\\Downloads\\Test.bmp");// fetch bitmap
                yield return bitmap;
            }
        }

        public bool SaveOutput(Bitmap filetosave)
        {
            return true;
        }

        private IEnumerable<string> Search(string sDir)
        {
            foreach (var file in Directory.GetFiles(sDir))
            {
                yield return file;
            }

            foreach (var directory in Directory.GetDirectories(sDir))
            {
                foreach (var file in Search(directory))
                    yield return file;
            }
        }
    }

}
