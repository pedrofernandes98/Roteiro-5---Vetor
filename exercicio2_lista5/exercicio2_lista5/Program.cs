using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_lista5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[15];
            int cont2 = 0, i;

            for(i=0; i<15; i++)
            {
                Console.WriteLine("Digite o valor da posição " + i + " do veto:");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for(i=0; i<15; i++)
            {
                if(vet[i] == 2)
                {
                    ++cont2;
                }
            }

            Console.WriteLine("QUantidade de posições com elementos iguais a 2: " + cont2);
            Console.WriteLine("Valores presentes no vetor que são múltiplos de 3:");

            for(i=0; i<15; i++)
            {
                if((vet[i] % 3) == 0)
                {
                    Console.Write(vet[i] + " | ");
                }
            }

            Console.WriteLine("\nPosições que possuem elementos múltiplos de 2: ");

            for(i=0; i<15; i++)
            {
                if((vet[i] % 2) == 0)
                {
                    Console.Write(i + "|");
                }
            }

            Console.ReadKey();


        }
    }
}
