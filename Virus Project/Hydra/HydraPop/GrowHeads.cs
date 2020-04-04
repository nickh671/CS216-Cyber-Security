using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraPop
{
    class GrowHeads
    {
        Form1 temp = new Form1();
        public void Grow(int headCount)
        {
            
            temp.recreate(headCount);
        }
    }
}
