using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiva_Coada
{
    /*
    public class Coada
    {
        int[] values;

        public Coada()
        {
            values = new int[0];
        }
        public void Push(int value)
        {
            int[] temp = new int[values.Length + 1];
            for(int i = 0; i < values.Length; i++) 
            {
                temp[i + 1] = values[i];
            }
            temp[0] = value;
            values = temp;
        }
        public int Pop()
        {
            int[] temp = new int[values.Length-1];
            int toR = values[values.Length - 1];
            for (int i = 0; i < temp.Length; i++) 
            {
                temp[i] = values[i];
            }
            values = temp;
            return toR;
        }
        public override string ToString()
        {
            return View();
        }
        public string View()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < values.Length - 1; i++)
            {
                sb.Append(values[i]);
                sb.Append(", ");
            }
            sb.Append(values[values.Length - 1]);
            return sb.ToString();
        }
    }
    */
}
