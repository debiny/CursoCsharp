using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_calcula_poupaca
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 10 - Calcula poupanca");


            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
	        {
                valorInvestido = valorInvestido + valorInvestido* 0.0036;
                Console.WriteLine("Apos " + contadorMes + " mes vc ter R$ " + valorInvestido);
                
                contadorMes++;
	        }
               Console.ReadLine();
            }
    }
}
