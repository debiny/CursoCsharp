using System;
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
            
            for ( int repeticao = 1;  repeticao == 10; repeticao++)
            {
               
                for(int fatorial = repeticao; fatorial != 0; fatorial--)
                {
                    int result = repeticao * fatorial;
                    Console.WriteLine(result);
                }
                }
            Console.ReadLine();
        }
    }
}
