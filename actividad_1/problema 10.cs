using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 namespace problema10
 {
     class Program
     {
       static void Main(string[] args)
       {
           int Clave
           int Contador
           int Intentos

           Clave  =  “iloveyou123”;
           Contador = 0 ;
           while (Contador < 3)
           {
               Console.Write("Digite la clave por favor")
               Intentos = Convert.Toint32(Console.ReadLine());
               if (Clave == Intentos)
               {
                  Console.WriteLine("La Clave ingresada es CORRECTA: ");
                  else
                  {
                     Console.WriteLine("La Clave ingresada es INCORRECTA: ");
                     Contador++; 
                  }
                  if (Contador == 3)
                  {
                       Console.WriteLine("Ha superado el numero de intentos....");
                  }
                  
               }
           }       
           Console.ReadKey();  
       }
     }
 }