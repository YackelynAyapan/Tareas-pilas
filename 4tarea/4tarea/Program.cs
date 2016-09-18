using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;// necesario para poder declarar un "STACK"

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();//instancio un nuevo objeto stack(pila)

            pila.Push(1);//agrego un elemento a la pila
            pila.Push(4);
            pila.Push(1);
            pila.Push(6);
            pila.Push(3);
            pila.Push(5);
            pila.Push(9);

            for (int i = 0; i < 3; i++)//itera 3 veces para ir retirando elementos de la pila
            {
                //pila.pop saca elementos de la pila
                Console.WriteLine("Elemento retirado de la pila: " + pila.Pop());//imprime los elementos que va retirando el .pop
                Console.WriteLine("el próximo elemento que queda en la pila es: " + pila.Peek());//muestra el elemento siguiente en la pila sin eliminarlo
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
