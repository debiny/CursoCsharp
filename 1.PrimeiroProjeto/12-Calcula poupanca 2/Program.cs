using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Calcula_poupanca_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula poupanca");
            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                //*= multiplicao valor da variavel e salva o resultado na propria variavel 
                valorInvestido *=  1.0036;
                Console.WriteLine("Apos " + contadorMes + " mes vc ter R$ " + valorInvestido);

            }
            Console.ReadLine();

        }
    }
}
