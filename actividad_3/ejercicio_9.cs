using System;
namespace Tipo_Triangulos
{
   class Program
   {
       static void Main(string[] args)
       {
           double l1, l2, l3;
           Console.Write("Introduzca el Valor Numerico del 1 Lado:");
           l1 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Introduzca el Valor Numerico del 2 Lado:");
           l2 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Introduzca el Valor Numerico del 3 Lado:");
           l3 = Convert.ToDouble(Console.ReadLine());
           if (l1 == l2 && l2 == l3)
               Console.WriteLine("\nEl Triangulo es Equilatero");
           else
           {
               if (l1 == l2 || l1 == l3 || l2 == l3)
                   Console.WriteLine("\nEl Triangulo es Isoceles");
           }
        }
    }
}                   