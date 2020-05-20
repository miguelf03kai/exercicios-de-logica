using System;

/**
 * Projeto: desenhar um triangulo
 *
 * Author: miguelf03kai
 */


namespace Drawing_Triangle
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i, j;

			for (i = 0; i<=20; i++) {
				for (j = 0; j<=i; j++) {
					Console.Write ("*");
				}
				Console.Write ("\n");
			}

			Console.WriteLine("\nPress any key to Continue...");
			Console.ReadKey ();
		}
	}
}
