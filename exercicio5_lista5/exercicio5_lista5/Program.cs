using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5_lista5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int[] vet_ordenado = new int[10];
            int i = 0,aux,j=0;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor da posição " + i + " do vetor:");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (vet[i] > vet[j])
                    {
                        aux = vet[i];
                        vet[i] = vet[j];
                        vet[j] = aux;
                    }
                }
            }

            Console.WriteLine("Vetor Ordenado:");

            for (i = 0; i < 10; i++)
            {
                Console.Write(vet[i] + "|");
            }

            Console.ReadKey();
        }
    }
}
