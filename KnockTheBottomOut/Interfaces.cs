using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace KnockTheBottomOut
{
    interface IBitmapStreamProvider
    {
        IEnumerable<Bitmap> FileQueue { get; }
        bool SaveOutput(Bitmap filetosave);
    }
}
