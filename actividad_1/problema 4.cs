using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problema4
{
  class Program
{
	public static void Main()
	{
		
		Console.WriteLine("Hola");
		int C,c;

		    Console.WriteLine("Escribe un nuemero para cumplir con la conjetura Collatz ");
		    C = int.Parse(Console.ReadLine());
		    c=C;
		
		    if (C == 1)
			{
				Console.WriteLine("Es imposible realizar la conjetura cuando el primer valor es 1");
				System.Console.ReadLine();
			}
		    else
			{
				 Console.WriteLine("La conjetura Collatz es: ");
                    System.Console.ReadLine();
				
				while (c > 1)  
					
				{
				if (c % 2 == 0)
					
					
				{
					c = (c / 2);
					Console.WriteLine("" + c);
					System.Console.ReadLine();
				}
				else
				{
					c = (c * 3) + 1;
					Console.WriteLine("" + c);
				}
				}
				
			}
		            Console.WriteLine("Fin");
                    System.Console.ReadLine();
					
					
					
					

		
		
		
	}
}
}
   