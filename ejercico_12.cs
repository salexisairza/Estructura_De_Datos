using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1=0, v2=0, v3=0, voto, max;
            double total, ov1, ov2, ov3;
            string ganador;

            Console.WriteLine("(1)oscar ortega(2)Santiago Solari");
            Console.WriteLine("(3)juan ariza(4)Salir");

            do
            {
                Console.Write("Ingrese el voto:");
                voto = int.Parse(Console.ReadLine());
                if (voto == 1)
                {
                    v1 = v1 + 1;
                }
                else if (voto == 2)
                {
                    v2 = v2 + 1;
                }
                else if (voto == 3)
                {
                    v3 = v3 + 1;
                }

            } while (voto != 4);
            
            
            total = v1 + v2 + v3;
            ov1 = (v1 / total) * 100;
            ov2 = (v2 / total) * 100;
            ov3 = (v3 / total) * 100;

            Console.WriteLine("Zinedine Zidane tiene : {0}", ov1);
            Console.WriteLine("Santiago Solari tiene : {0}", ov2);
            Console.WriteLine("Julen Lopetegui tiene : {0}", ov3);

            max = v1;
            ganador = "Zinedine Zidane";
            if (v2 > max)
            {
                ganador = "Santiago Solari";
            }
            if (v3 > max)
            {
                ganador = "Julen Lopetegui";
            }

            Console.WriteLine("Felicidades a : {0} es el nuevo represntante estudiantil", ganador);
                    
            Console.ReadLine();
        }
    }
}
