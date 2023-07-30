using System;

namespace GetSet// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pessoa P = new Pessoa();
            P.Nome = "Gustavo";
            Console.WriteLine(P.Nome);
        }
    }
}