using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_lista5
{
    class Program
    {
        static void Main(string[] args)
        {
            //O intuito desde programa consiste basicamente em preencher um vetor de 10 posições solicitando ao usuário que 
            //digite o valor de cada uma das posições, calulca a média dos valores presentes nas posições 6, 7, 8 e 9, e 
            //posteriormente, imprime na tela o vetor completo com todos os valores digitados além do valor calculado da média.
            //Segue a baixo a explicação de cada um dos comandos utilizados para o funcionamento da solução descrita acima:
            double[] num = new double[10]; //Comando que estancia um vetor que irá receber dados do tipo double e define que o vetor terá 10 posições para serem preenchidas, ou seja, ao ser executado, este comando aloca 10 espaços de memória do tipo double para que possam ser preenchidas.
            int qtde = 0;// Comanda que declara uma variável do tipo inteiro e incializa(armazena) (n)ela o valor 0
            double soma = 0, media;// Comando que declara uma variável do tipo double de noma 'soma' e armazena nela o valor 0 para que nela seja armazenada o valor da soma dos valores das posições 6, 7, 8 e 9.Desta forma, essa inicialização é importante para que o programa faça uma soma correta e não inclua lixo de memória na mesa. Declara outra variável do tipo double denominada 'media' sem inicializá-la.
            for (int x = 0; x < 10; x++)// Estrutura de repetição FOR, que tem em sua primeira parte, a condição de inicialização, declarando uma variável de nome 'x' do tipo inteiro e que é incializada com o valor '0' e será utilizada como variável de controle do for. A segunda parte da estrutura de repetição FOR, consiste na condição de parada que no caso apresentado indica que enquando a variável x for menor que 10 todas os comando presentes na estrutura FOR serão executados. Por fim, a última parte do for consiste em um incremento na sua variável de controle 'x'.
            {
                Console.WriteLine("Digite o valor " + x + ": ");//Comando de saída que imprime na tela um texto que solicita ao usuário digitar o valor que corresponte à posição 'x' do vetor
                num[x] = int.Parse(Console.ReadLine());//Comando de entrada que lê o valor digitado pelo usuário, converte o valor em inteiro e o armazena na posição 'x' do vetor. É importante salientar que a variável x também é utilizada para fazer o controle das posições do vetor, já que a medida que ela vai sendo incrementada, ela também se movimenta em meio às posições do vetor permitindo assim que todo o vetor seja percorrido e preenchido conforme a estrutura de repetição também vai sendo incrementada.

            }
            for (int x = 0; x < 10; x++)//Estrutura de repetição FOR que possui o mesmo funcionamento e lógica da primeira e que é utlizada para que seja percorrido as posições do vetor e fazer a soma dos valores das posições de índices ">5"
            {

                if (x > 5)//Estrutura condicional if que verifica se o valor da variável 'x' é maior que 5. Caso a condição seja verdadeira, o programa executará todas as instruções dentro das chaves que demarcam a estrutura condicional, caso seja falsa, os comandos não serão executados
                {
                    qtde++;//Comando que incrementa o valor da variável 'qtde'
                    soma = soma + num[x]; //Processamento que armazena na variável 'soma' o valor armazena dentro da própria variável soma somado ao valor armazenado na posição 'x' do vetor 'num'
                }
            }
            Console.WriteLine("Valores do vetor: ");//Comando de Saída que imprime na tela os caracteres presentes em mios as aspas
            for (int x = 0; x < 10; x++)//Estrutura de repetição FOR que possui o mesmo funcionamento dos demais apresentados no programa e é utilizado para percorrer todas as posições do vetor e permitir imprimi-los na tela.
            {
                Console.Write(num[x] + " | ");//Comando de saída que imprime na tela o valor da posição 'x' do vetor e como a estrutura de repetição irá precorrer todas as suas posições, todo o vetor será impresso na tela para vizualização

            }
            media = soma / qtde;//Processamento que calcula a média dos valores armazenados nas posições acima do índice 5, fazendo a divisão do valor armazenado na variável 'soma' pelo valor armazenado na variável 'qtde'
            Console.WriteLine("\nA media é: " + media);//COmando de saída que imprime na tela o valor da média calculado
            Console.ReadKey();//COmando que "congela" a tela do programa até que algum caracter seja digitado para que o programa seja finalizado
        }
    }
}
