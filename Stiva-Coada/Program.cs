using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiva_Coada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*TADL coada = new MyQueue();
 
            for(int i = 0; i < 10; i++)
            {
                coada.Push(i);
            }
            Console.WriteLine(coada.View());
            coada.Pop();
            coada.Pop();
            Console.WriteLine(coada.View());*/

            RPN rpn = new RPN();
            rpn.Eval();
            Console.ReadKey();
        }
    }
}
