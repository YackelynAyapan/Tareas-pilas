using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace pop
{
    class Program
    { static int este;
        static void Main(string[] args)
        {
            Stack miPila = new Stack(10);
            int opcion;//opcion del menu 
          
            do
            {
                Console.Clear();//se limpia consola
                agregar(ref miPila);
                opcion = menu();//muestra menu y espera opción
                switch (opcion)
                {
                   
                    case 1:
                        eliminar(ref miPila);
                        break;
                    case 2:
                        imprimir(miPila);
                        break;
                    
                    case 3: break; //salir
                    default:
                        mensaje("ERROR: la opción no es valida. Intente de nuevo.");
                        break;
                }

            }
            while (opcion != 4);

            mensaje("El programa a finalizado.");
        }
        /** añade un nuevo elemento a la pila */
        static void agregar(ref Stack pila)
        {

            Console.Write("\n>La pila se esta llenando ");
            for (int i = 0; i < 10; i++)
            {
                pila.Push(i);



            }



        }


        /** Elimina elemento de la pila */
        static void eliminar(ref Stack pila)
        {
            Console.WriteLine("Ingrese valor:");
            este = int.Parse(Console.ReadLine());
            
            while (pila.Count == este) { 
                 int valor = (int)pila.Pop();
                 mensaje("Elemento " + valor + " eliminado");
                 imprimir(pila);
              
             }  Console.WriteLine( " valor encontrado" );
            
            

       /** muestra menu y retorna opción */
        }
        static int menu()
        {
            //Console.Clear();
            Console.WriteLine("\n            Stack Menu\n");
         
            Console.WriteLine(" 1.- Buscar elemento");
            Console.WriteLine(" 2.- Imprimir");
           
           
            Console.WriteLine(" 3.- Termina programa");
            Console.Write("  Ingresa tu opción: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {
                return 0;
            }
        }

        /** Muestra mensaje del programa al usuario */
        static void mensaje(String texto)
        {
            if (texto.Length > 0)
            {
                Console.WriteLine("\n    =======================================================");
                Console.WriteLine("  {0}", texto);
                Console.WriteLine(" =======================================================");
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        /** Imprime pila */
        static void imprimir(Stack pila)
        {
            if (pila.Count > 0)
            {
                Console.WriteLine("");
                foreach (int dato in pila)
                {
                    Console.WriteLine(" |      |");
                    if (dato < 10)
                        Console.WriteLine(" | 0{0}  |", dato);
                    else
                        Console.WriteLine(" | {0}  |", dato);
                    Console.WriteLine(" |______|");
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                mensaje("La Pila esta vacia");
            }
        }
    }


}
