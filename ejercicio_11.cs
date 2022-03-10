using System;

namespace ejercicio

{

  Sueltos entre género masculino y femenino

   {

       static void Main()

       {

           string[] legajo = new string[10];

           float[] sueldo = new float[10];

           int[] op = new int[10];

           int i;

           for (i = 0; i < 10; i++)

           {

               Console.WriteLine("{0}º persona", i + 1);

               Console.Write("Sueldo:");

               sueldo[i] = float.Parse(Console.ReadLine());

               Console.Write("Legajo:");

               legajo[i] = Console.ReadLine();

               Console.Write("1 = Femenino, 2 = Masculino:");

               op[i] = int.Parse(Console.ReadLine());

           }

           Console.WriteLine();

           for (i = 0; i < 10; i++)

           {

               if (op[i] == 1 && sueldo[i] > 500 || op[i] == 2 && sueldo[i] < 400)

                   Console.WriteLine("Legajo: {0}|género: {1}|Sueldo: {2}", legajo[i], op[i], sueldo[i]);

           }

          Console. Read();

       }

   }

}