﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13___ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13");

            //Escrevendo com um break
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine(); //Pula a linha

            }

            //Uma forma diferente de fazer o desenho de asterisco
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");

                }
                Console.WriteLine(); //Pula a linha
            }
                Console.ReadLine();
        }
    }
}
