using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado=0;
            double numero=0;
            double potencia=0;

            Console.WriteLine("Ingrese Numero a elevar");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Potencia");
            potencia = int.Parse(Console.ReadLine());

            resultado = Math.Pow(numero, potencia);

            Console.Write("Resultado " + resultado);

            Console.ReadKey();
        }
      
    }
}
