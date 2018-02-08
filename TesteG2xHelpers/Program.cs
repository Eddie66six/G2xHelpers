using G2xHelpers;
using System;

namespace TesteG2xHelpers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("guilherme@w12.com.br".IsEmail());
            Console.WriteLine("12.200,00".IsNumber());
            Console.WriteLine("123adf".LimitChar(6, "..."));
            Console.WriteLine("lista_clientes.lista clientes-lista".ToCamelCase());
            Console.WriteLine("Aássée^".RemoveAccents());
            Console.ReadKey();
        }
    }
}
