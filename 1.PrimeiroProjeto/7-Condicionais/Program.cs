using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7");
            int idadejoao = 16;
            int quantidadePessoas = 2;

            if (idadejoao >= 18)
            {
                Console.WriteLine("Joao possui mais de 18 anos de idade");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Joao não possui mais de 18 anos de idade, mais esta acompanhado");
                }
                else
                {
                    Console.WriteLine("Joao não possui mais de 18 anos de idade");

                }
            }


            Console.ReadLine();

        }
    }
}
