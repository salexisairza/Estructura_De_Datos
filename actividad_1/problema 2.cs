using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problema2
{
   class Program
{
	public static void Main()
	{
		
		
            Console.WriteLine("Bienvenido al videoclub Spartan, el dia de hoy tenemos una super promoción llevate 3 peliculas y paga las 2 más baratas!");
           
            double Precio1;
            double Precio2;
            double Precio3;
            double Operación1;

            Console.Write("Ingrese el primer precio ");
            Precio1 =
                double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo precio ");
            Precio2 =
                double.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer precio ");
            Precio3 =
                double.Parse(Console.ReadLine());
            
            if (Precio1 > Precio2 && Precio1 > Precio3)
            {
                Operación1 = Precio2 + Precio3;
                Console.WriteLine("La promoción es: " + Operación1);
            }
            
            else if (Precio2 > Precio1 && Precio2 > Precio3)
            {
                Operación1 = Precio1 + Precio3;
                Console.WriteLine("El precio de la promoción es: " + Operación1);
            }
            else
            {
                Operación1 = Precio2 + Precio1;
                Console.WriteLine("El precio de la promoción es: " + Operación1);
            }
            Console.ReadLine();
            Console.WriteLine("Gracias por su compra , regrese pronto");
            Console.ReadLine();


        }
	}
}					
 