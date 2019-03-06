using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4_lista5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor_resultante = new int[10];
            int i = 0;

            for (i = 0; i < 5; i++)
            {
                    Console.WriteLine("Digite o valor da posição " + i + " do vetor 1:");
                    vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o valor da posição " + i + " do vetor 2:");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

    

            for (i = 0; i < 5; i++)
            {
                if(i == 0)
                {
                    vetor_resultante[i] = vetor1[i];
                }
                else
                {
                    vetor_resultante[i * 2] = vetor1[i];
                }
            }
      
            for (i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    vetor_resultante[i+1] = vetor2[i];
                }
                else
                {
                    vetor_resultante[(i * 2)+1] = vetor2[i];
                }
            }

            Console.WriteLine("Vetor Resultante:");

            for (i = 0; i < 10; i++)
            {
                Console.Write(vetor_resultante[i] + "|");
            }

            Console.ReadKey();

        }
    }
}
