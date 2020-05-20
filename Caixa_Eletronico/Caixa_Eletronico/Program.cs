using System;

/*Um caixa eletrônico possui notas de 
 *R$ 50,00
 *R$ 20,00
 *R$ 10,00
 *Faça um programa que calcule quantas notas de cada deve ser fornecida para o 
 *cliente, ao realizar um saque de um determinado valor.
 */

namespace Caixa_Eletronico
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int saque, nota50, nota20, nota10;

			Console.Write("Caixa Eletronico\n------------------------------------------------\n" +
			                  "Cedulas disponiveis R$ 10,00  R$ 20,00  R$ 50,00\n\n" +
			                  "Digite Valor do Saque: ");

			saque = Convert.ToInt32(Console.ReadLine ());

			nota50 = saque / 50;
			nota20 = (saque % 50) / 20;
			nota10 = ((saque % 50) % 20) / 10;

			Console.WriteLine ("\nNotas de R$ 50,00: "+nota50);
			Console.WriteLine ("Notas de R$ 20,00: "+nota20);
			Console.WriteLine ("Notas de R$ 10,00: "+nota10);

			Console.WriteLine("\n------------------------------------------------");

			Console.WriteLine("\nPressione qual quer tecla para sair...");
			Console.ReadLine ();

		}
	}
}
