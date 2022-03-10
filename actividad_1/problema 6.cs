using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class1
{
	class problema6
	{
	    static void Main(string[] args)
        {
			Console.write("Por favor introduce un numero en segundos:");

			int SegundosTotales = Convert.ToInt33(console.readline());

			int dias = SegundosTotales / (60 * 60 * 24);

			int SegundosRestantes = SegundosTotales % (60 * 60 * 24);

			int horas = SegundosRestantes / (60 * 60);

			SegundosRestantes = SegundosRestantes % (60 * 60);

			int minutos = SegundosRestantes / 60;

			int segundos = SegundosRestantes % 60;

			console.writeline(dias + "dias,");

			console.writeline(horas + "horas,");

			console.writeline(minutos + "minutos,");

			console.writeline(segundos + "segundos");

			console.ReadKey();

		}
	}
}
