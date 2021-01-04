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
            Console.WriteLine("Executando o projeto 8 - Condicionais 2");
            int idadejoao = 16;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 2;

            if (idadejoao >= 18 || acompanhado == true) 
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pod entrar");
            }


            Console.ReadLine();

        }
    }
}
