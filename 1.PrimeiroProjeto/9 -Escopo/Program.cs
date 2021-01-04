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
            Console.WriteLine("Executando o projeto 8 -Escopo");
            int idadejoao = 16;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 2;

            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "Joao esta acompanhado";
            }
            else
            {
                mensagemAdicional = "não esta acompanhado";
            }

            if (idadejoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);

            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }


            Console.ReadLine();

        }
    }
}
