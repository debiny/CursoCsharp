using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int repeticao = 0; repeticao <= 100; repeticao++)
            {
                double resto = repeticao % 3;

                if (resto == 0)
                {
                    Console.WriteLine("O numero " + repeticao + " é divisivel por 3 ");

                }
            }
            Console.ReadLine();
        }
    }
}
