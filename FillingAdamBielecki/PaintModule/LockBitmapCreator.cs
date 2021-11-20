using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public class LockBitmapCreator : IBitmapManagerCreator
    {
        public BitmapManager CreateBitmapManager()
        {
            return new LockBitmap();
        }
    }
}
