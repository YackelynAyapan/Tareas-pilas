using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace letra_al_revez
{
    using System;

    class Class1
    {
        public static void Main()
        {
            string p;
            int l;
            int i = 0;
            Console.WriteLine("ingrese la palabra que desea invertir:");
            p = Console.ReadLine();
            l = p.Length;

            string[] derecho = new string[l];

            for (i = 0; i < l; i++)
            {
                derecho[i] = p.Substring(i, 1);
            }

            for (i = l - 1; i >= 0; i--)
                Console.Write(derecho[i]);

            Console.Read();
        }
    }

}






