using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos ");

            //char segue a ascii table
            char PrimeiraLetra = 'a';

            Console.WriteLine(PrimeiraLetra);

            PrimeiraLetra = (char)65;

            Console.WriteLine(PrimeiraLetra);

            PrimeiraLetra = (char)(PrimeiraLetra + 1);

            Console.WriteLine(PrimeiraLetra);

            string titulo = "Alura curso de texnologia" + 2020;

            Console.WriteLine(titulo);

            string listaCursos = @" -Java
-JNet
-Javascript";

            Console.WriteLine(listaCursos);

            Console.ReadLine();
        }
    }
}
