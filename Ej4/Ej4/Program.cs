using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, divisor;


            Console.Write("\t\t Números primos del 1 al 1000\n\n");
            Console.Write("\n\n Puede que numeros se repitan \n\n");
            for (n = 2  ; n <= 10; n++) // Cambiar a mil para probar 
            {
                for (divisor = 2; n % divisor != 0; divisor++)
                {
                    if (divisor == n)
                    
                       Console.Write(" - " );

                     Console.Write(" - "+n);
                     
                }
               

            }
            Console.ReadKey();
        }
    }
   
  }
 