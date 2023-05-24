using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiva_Coada
{
    public abstract class TADL
    {
        protected float[] values;

        protected TADL()
        {
            values = new float[0];
        }

        public virtual void Push(float value)
        {
            float[] temp = new float[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
            {
                temp[i + 1] = values[i];
            }
            temp[0] = value;
            values = temp;
        }
        public abstract float Pop();
        public virtual string View()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < values.Length - 1; i++)
            {
                sb.Append(values[i]);
                sb.Append(", ");
            }
            sb.Append(values[values.Length - 1]);
            return sb.ToString();
        }
    }
}
