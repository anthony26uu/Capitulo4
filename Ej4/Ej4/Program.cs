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


            Console.Write("\n\n Números primos del 1 al 1000\n\n");

            for (n = 2  ; n <= 1000; n++)
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
 