using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiva_Coada
{
    public class MyStack: TADL
    {
        public MyStack(): base() { }
        public override float Pop()
        {
            float[] temp = new float[values.Length - 1];
            float toR = values[0];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = values[i + 1];
            }
            values = temp;
            return toR;
        }
    }
}
