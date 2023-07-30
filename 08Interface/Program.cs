using System;

namespace ExInterface // Usando herança no c#
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface");
            Operacoes Op = new Operacoes();
            Op.somar(10, 5);
            Op.subtrair(10, 8);
        }
    }
}