using System;

namespace EvidenciaU1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int sideOne;
			int sideTwo;
			decimal perimeter;
			decimal area;

			CAutor autor = new CAutor ();
			Console.WriteLine("Este programa calcula el área y perímetro de un rectángulo de cualquier medida \n");

			Console.WriteLine("Ingrese el lado 1: ");
			sideOne = Int32.Parse(Console.ReadLine());
			Console.WriteLine ("Ingrese el lado 2: ");
			sideTwo = Int32.Parse(Console.ReadLine());

			perimeter = (sideOne * 2) + (sideTwo * 2);
			area = sideOne * sideTwo;

			Console.WriteLine ("El perimetro es: {0: 0.00} \n" +
			"El area es: {1: 0.00} \n", perimeter, area);
		}
	}

	class CAutor
	{
		public CAutor()
		{
			Console.WriteLine ("Nombre: Diego Plascencia \n" +
			"Matricula: ES1421004131 \n" +
			"Actividad: Evidencia de Aprendizaje 1 - Programa en C# \n" +
				"Fecha y hora: {0:dd/M/yy H:mm:ss} \n \n", DateTime.Now);
		}
	}
}
