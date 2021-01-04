using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 ");

            double salario = 1200.50;

            //convertendo double em inteiro
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            //int suporte ate 2 bilhoes 34bytes
            int numero = 10000;
            Console.WriteLine(numero);


            //variavel para numeros inteiros grandes 64byts
            long idade;
            idade= 130000000000;
            Console.WriteLine(idade);

            //numero de 16 buts, aceita uns 16mil
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            //
            float altura = 1.80f;
            Console.WriteLine(altura);


            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
