using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 2 - Criando variaveis potno flutuante");

            double salario = 1200.70;
            Console.WriteLine(salario);

            //um double aceita numero inteiro porem se realizar um calculo com dois numero inteiros vc perde as casas decimais
            //entao um dos numeros envolvidos no calculo tem que ser um double
            double idade = 5/ 3;
            Console.WriteLine("A divisão de 5 por 3 é igual a :" + idade);

            idade = 5.0 / 3;
            Console.WriteLine("A divisão de 5.0 por 3 é igual a :" + idade);

            Console.WriteLine("A execução acabou. Tecle enter para finalizar");
            Console.ReadLine();
        }
    }
}
