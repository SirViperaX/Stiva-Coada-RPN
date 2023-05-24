using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiva_Coada
{
    public class RPN
    {
        string value;

        public RPN()
        {
            Load("D:\\Faculta\\Stiva-Coada\\Stiva-Coada\\Input.txt");
        }

        public void Load(string fileName)
        {
            TextReader reader = new StreamReader(fileName);
            value = reader.ReadLine();
            reader.Close();
        }
        public float Eval()
        {
            string[] data = value.Split(' ');
            TADL a = new MyStack();
            for (int i = 0; i < data.Length - 1; i++)
            {
                if ((data[i])[0] >= '0' && (data[i])[0] <= '9')
                    a.Push(float.Parse(data[i]));
                else
                {
                    float t1 = a.Pop();
                    float t2 = a.Pop();
                    switch (data[i][0])
                    {
                        case '+':
                            a.Push(t2 + t1);
                            break;
                        case '-':
                            a.Push(t2 - t1);
                            break;
                        case '*':
                            a.Push(t2 * t1);
                            break;
                        case ':':
                            a.Push(t2 / t1);
                            break;
                    }
                }
                Console.WriteLine(a.View());
            }       
            return a.Pop();
        }
    }
}
