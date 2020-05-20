using System;
/*
 *Elabore um algoritmo que receba a altura de 30 pessoas, calcule e apresente na tela: a
 *maior altura, a menor altura, a média de altura, o número de pessoas com menos de 18
 *anos, o número de pessoas com mais de 60 anos. Para isso, utilize a estrutura enquanto.
 */

namespace Altura_e_idade
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i = 1,idade,count18 = 0,count60 = 0;
			double maior_altura = 0, menor_altura = 0, media = 0,altura = 0;

			while(i <= 30){

				Console.WriteLine ("\nentre com a altura da "+i+"ª pessoa: ");
				altura = Convert.ToDouble (Console.ReadLine ());
				Console.WriteLine ("entre com a idade da "+i+"ª pessoa: ");
				idade = Convert.ToInt32 (Console.ReadLine ());

				if (idade < 18) {
					count18 += 1;
				} else if (idade > 60) {
					count60 += 1;
				}

				media += altura;

				if (altura > maior_altura) {
					maior_altura = altura;
				} else if (altura < menor_altura) {
					menor_altura = altura;
				} else if (menor_altura == 0) {
					menor_altura = altura;
				}

				i++;
			}
			Console.WriteLine ("maior altura: "+maior_altura+"\nmenor altura: "+menor_altura+"\nmedia: "
			                   +(media)/2+"\nidade menor que 18: "+count18+"\nidade maior que 60: "+count60);

			Console.ReadKey ();

		}
	}
}
