using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Exercicio_Alicota_com_ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salario no formato R$ 0000.00");
            string salario = Console.ReadLine();
            double valSal = Double.Parse(salario);

            if (valSal <= 1903.98)
            {
                Console.WriteLine("Voce é isento;");
                Console.ReadLine();
            }

            if (valSal <= 2826.65)
            {
                Console.WriteLine("o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142,80");
                Console.ReadLine();
            }
            else if (valSal <= 3751.05)
            {
                Console.WriteLine("o IR é de 15% e pode deduzir R$ 354,80");
                Console.ReadLine();

            }
            else if (valSal <= 4664.68)
            {
                Console.WriteLine("o IR é de 22.5% e pode deduzir R$ 636.13");
                Console.ReadLine();

            }
            else if (valSal > 4664.68)
            {
                Console.WriteLine("o IR é de 27.5% e pode deduzir R$ 869.36");
                Console.ReadLine();

            }

        }
    }
}
