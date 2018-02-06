using System;

namespace TesteG2xHelpers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(G2xHelpers.G2xString.IsEmail("guilherme@w12.com.br"));
            Console.WriteLine(G2xHelpers.G2xString.IsNumber("12"));
            Console.WriteLine(G2xHelpers.G2xString.LimitChar("123adf", 6, "..."));
            Console.ReadKey();
        }
    }
}
