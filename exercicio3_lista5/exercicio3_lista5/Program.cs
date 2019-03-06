using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3_lista5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[6];
            int cont3=0, i=0,j=0,k=0;

            for (i = 0; i < 6; i++)
            {

                do
                {
                    Console.WriteLine("Digite um número inteiro positivo: ");
                    vet[i] = int.Parse(Console.ReadLine());

                    if (vet[i] < 0)
                    {
                        Console.WriteLine("Valor inválido! Digite um valor válido para continuar");
                    }

                } while (vet[i] < 0);

                if ((vet[i] % 3) == 0)
                {
                    cont3++;
                }

            }

            int[] multiplo3 = new int[cont3];
            int[] vetor2 = new int[6 - cont3];

            for (i = 0; i < 6; i++)
            {
                if ((vet[i] % 3) == 0)
                {
                    multiplo3[j] = vet[i];
                    ++j;

                }
                else
                {
                    vetor2[k] = vet[i];
                    ++k;
                }

            }

            Console.WriteLine("\nVetor com numeros multiplos de 3:");
            for(i=0; i<cont3; i++)
            {
                Console.Write(multiplo3[i] + "|");
            }

            Console.WriteLine("\nVetor com numeros não multiplos de 3:");
            for (i = 0; i < k; i++)
            {
                Console.Write(vetor2[i] + "|");
            }

            Console.ReadKey();

        }
    }
}
