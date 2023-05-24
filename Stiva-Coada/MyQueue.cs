using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiva_Coada
{
    public class MyQueue : TADL
    {
        public MyQueue(): base() { }
        public override float Pop()
        {
            float[] temp = new float[values.Length - 1];
            float toR = values[values.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = values[i];
            }
            values = temp;
            return toR;
        }
    }
}
