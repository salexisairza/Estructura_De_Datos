using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problema3
{
     class Program
{
	public static void Main()
	{
		
            Console.WriteLine("Bienvenido por favor ingresa las calificaciones ");
            double calificación1, calificación2, calificación3, calificación4;
            Console.WriteLine("Ingresa el calificación1  ");
            calificación1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa el calificación2 ");
            calificación2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa el calificación3 ");
            calificación3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa el calificación4 ");
            calificación4 = int.Parse(Console.ReadLine());

            double opera_1;
            opera_1 = (calificación1 + calificación2 + calificación3 + calificación4) / 4;
            Console.WriteLine("El promedio es " + opera_1);
            if(calificación1 < calificación2 && calificación1 < calificación3 && calificación1<calificación4)
            {
                Console.WriteLine("el valor minimo es la primera");
                Console.ReadLine();
            }
            if(calificación2 < calificación1 && calificación2 < calificación3 && calificación2 < calificación4)
            { 
                Console.WriteLine("el valor minimo es la segunda ");
            Console.ReadLine();
            }
            if (calificación3 < calificación1 && calificación3 < calificación2 && calificación3 < calificación4)
            {
                Console.WriteLine("el valor minimo es el tercero ");
                Console.ReadLine();
            }
            if (calificación4 < calificación1 && calificación4 < calificación2 && calificación4 < calificación3)
            {
                Console.WriteLine("el valor minimo es la cuarta ");
                Console.ReadLine();
            }
            if (calificación1 > calificación2 && calificación1 > calificación3 && calificación1 > calificación4)
            {
                Console.WriteLine("el valor mayor es la primera");
                Console.ReadLine();
            }
            if (calificación2 > calificación1 && calificación2 > calificación3 && calificación2 > calificación4)
            {
                Console.WriteLine("el valor mayor es la segunda ");
                Console.ReadLine();
            }
            if (calificación3 > calificación1 && calificación3 > calificación2 && calificación3 > calificación4)
            {
                Console.WriteLine("el valor mayor es el tercero ");
                Console.ReadLine();
            }
            if (calificación4 > calificación1 && calificación4 > calificación2 && calificación4 > calificación3)
            {
                Console.WriteLine("el valor mayor es la cuarta ");
                Console.ReadLine();
            }

    }
}


}					
