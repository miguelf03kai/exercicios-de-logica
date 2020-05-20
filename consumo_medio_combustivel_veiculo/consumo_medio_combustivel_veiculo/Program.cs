using System;

/*
 *Construir um algoritmo capaz de calcular o consumo médio de combustível de um
 *veículo. Para isso, o usuário deverá informar como entrada os quilômetros percorridos
 *pelo veículo e o total de litros usados para abastecê-lo.
 */

namespace consumo_medio_combustivel_veiculo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double consumoMedio, km_percorrido, comb_litros;

			Console.Write ("digite quilometro percorrido: ");
			km_percorrido = Convert.ToDouble(Console.ReadLine());
			Console.Write ("digite com o total de litros do abastecimento: ");
			comb_litros = Convert.ToDouble(Console.ReadLine());

			consumoMedio = km_percorrido / comb_litros;

			Console.Write ("\nA Media de consumo do Veiculo e de "+consumoMedio+" por litro");

			Console.WriteLine("\n\nPressione qual quer tecla para sair...");
			Console.ReadLine ();

		}
	}
}
