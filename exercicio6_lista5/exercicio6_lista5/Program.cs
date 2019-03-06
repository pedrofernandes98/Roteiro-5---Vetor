using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6_lista5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[10];
            int[] peso = new int[10];

            int i, cont1 = 0, cont2 = 0, soma=0, cont3 = 0;
            double media;

            for (i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Digite a idade da pessoa " + i + " : ");
                    idade[i] = int.Parse(Console.ReadLine());

                    if (idade[i] <= 0)
                    {
                        Console.WriteLine("Número inválido! Digite outro número");
                    }
                } while (idade[i] < 0);



                do
                {
                    Console.WriteLine("Digite o peso(em kg) da pessoa " + i + " : ");
                    peso[i] = int.Parse(Console.ReadLine());

                    if (peso[i] <= 0)
                    {
                        Console.WriteLine("Número inválido! Digite outro número");
                    }
                } while (peso[i] < 0);
                                                                                 
            }

            for (i = 0; i < 10; i++)
            {
                if(idade[i] > 50)
                {
                    ++cont1;
                }

                if(peso[i] > 70)
                {
                    ++cont2;
                }

                if(idade[i] >= 20 && idade[i] <=30)
                {
                    soma += peso[i];
                    ++cont3;
                }
            }

            Console.WriteLine("Quantidade de pessoas com idade superior a 50 anos: " + cont1);
            Console.WriteLine("quantidade de pessoas com peso superior a 70 kilos: " + cont2);

            if(cont3 == 0)
            {
                Console.WriteLine("Não foi contabilizada pessoas com idade entre 20 a 30, logo não é possível calcular a média.");
            }
            else
            {
                media = (double)soma / (double)cont3;
                Console.WriteLine("Média do peso das pessoas com idades entre 20 e 30 anos: " + media);
            }

            Console.ReadKey();

        }
    }
}
