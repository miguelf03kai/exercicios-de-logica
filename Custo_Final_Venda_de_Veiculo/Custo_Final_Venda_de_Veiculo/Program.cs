using System;

/*Problema: O custo ao consumidor de um carro novo, é a soma do custo de fábrica com a percentagem do
 *revendedor e com o custo dos impostos (aplicados ao custo de fábrica). Supondo que a percentagem do
 *revendedor seja de 25% do custo de fábrica e que os impostos custam 45 % do custo de fábrica, faça
 *um algoritmo que leia o valor de custo de fábrica e determine o preço final do automóvel (custo ao
 *consumidor).
 *
 *Author: miguelf03kai
 */

namespace Custo_Final_Venda_de_Veiculo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double val_fabrica,val_revenda,val_imposto,val_final;

			Console.Write("Entre com o valor de fabrica do Carro: ");
			val_fabrica = Convert.ToDouble (Console.ReadLine());

			val_revenda = (val_fabrica * 25)/100;
			val_imposto = (val_fabrica * 45)/100;

			val_final = val_fabrica+val_imposto+val_revenda;

			Console.WriteLine("Valor Final do Carro: "+val_final);

			Console.WriteLine ("\npressione qual quer tecla para continuar...");
			Console.ReadKey ();
		}
	}
}
