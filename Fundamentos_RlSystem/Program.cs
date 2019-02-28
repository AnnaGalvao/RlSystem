using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_RlSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar variaveis
            
            int n1 = 0;
            int n2 = 0;
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;


            // Printar na tela
            //Console.WriteLine(nome);
            Console.WriteLine("----Calculadora----");

            Console.WriteLine("Digite o primeiro valor");
            n1 = Convert.ToInt32(Console.ReadLine()); // Readeline retorna string, entao deve o valor deve ser convertido para inteiro

            Console.WriteLine("Digite o segundo valor");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            total1 = n1 + n2; //operaão aritmética
            total2 = n1 - n2;
            total3 = n1 * n2;
            total4 = n1  / n2;

            Console.WriteLine("O Valor da soma é = " + total1);
            Console.WriteLine("O Valor da subtração é = " + total2);
            Console.WriteLine("O Valor da multiplicação é = " + total3);
            Console.WriteLine("O Valor da divisão é = " + total4);


            /*
             Esse é exemplo de comentarios com varias linhas

             */

            Console.ReadLine(); // Nao fechar aplicação


        }
    }
}
