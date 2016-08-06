using System;

// Initial namespace of solution
namespace EvidenciaU1
{
	// Main initial class of console program
	class MainClass
	{
		// intial program
		public static void Main (string[] args)
		{
			// side one of rectangle
			int sideOne;
			// side two of rectangle
			int sideTwo;
			// to store perimeter in decimal
			decimal perimeter;
			// to store area in decimal
			decimal area;

			// CAutor class initialization and exec its constructor, with a console message
			CAutor autor = new CAutor ();
			// write in console a message of program info
			Console.WriteLine("Este programa calcula el área y perímetro de un rectángulo de cualquier medida \n");

			// message to user that ask for side one of rectangle
			Console.WriteLine("Ingrese el lado 1: ");
			// parse user entry to int and store in sideOne var
			sideOne = Int32.Parse(Console.ReadLine());
			// message to user that ask for side two of rectangle
			Console.WriteLine ("Ingrese el lado 2: ");
			// parse user entry to int and store in sideOne var
			sideTwo = Int32.Parse(Console.ReadLine());

			// calc perimeter with formula and user rectangle info
			perimeter = (sideOne * 2) + (sideTwo * 2);
			// calc area with formula and user rectangle info
			area = sideOne * sideTwo;

			// format string with two decimals of result of perimeter and area
			Console.WriteLine ("El perimetro es: {0: 0.00} \n" +
			"El area es: {1: 0.00} \n", perimeter, area);
		}
	}

	/// <summary>
	///  required CAutor class that only writes a console message on initialization
	/// </summary>
	class CAutor
	{
		// class constructor
		public CAutor()
		{
			// write console message with author info
			Console.WriteLine ("Nombre: Diego Plascencia \n" +
			"Matricula: ES1421004131 \n" +
			"Actividad: Evidencia de Aprendizaje 1 - Programa en C# \n" +
				"Fecha y hora: {0:dd/M/yy H:mm:ss} \n \n", DateTime.Now);
		}
	}
}
