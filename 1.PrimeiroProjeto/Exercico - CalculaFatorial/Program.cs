﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Fatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;  
            for (int i = 1; i < 5; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + "=" + fatorial);
            }
            Console.ReadLine();
        }
    }
}
