using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ej5
{
    class Program
    {
        static void Main()
        {
            int num;


          


            Console.WriteLine("Ingrese Numero de edades");
            num = int.Parse(Console.ReadLine());
            int s=0;
            int[] edades = new int[num];

            

            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Ingrese Edad ");
                edades[i] = int.Parse(Console.ReadLine());

               
            }
            
            for (int id=0; id<edades.Length; id++)
            {
                Console.WriteLine("Elemento {0}: {1}", id, edades[id]);

               
                    s += edades[id];
              

            }

            Console.WriteLine("Su suma es "+s);
            Console.WriteLine("Promedio de edades es " + s / edades.Length);


          Array.Sort(edades);
            Console.WriteLine("Edad menor es: " + edades[0]);
            Array.Reverse(edades);
            Console.WriteLine("Edad mayor es: " + edades[0]);
            



            Console.ReadKey();
        }
    }

}
