using System;

namespace Conceitos 
{
    internal class Program  // APP DE IMC USANDO POO 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, vamos calcular o seu IMC! \n");
            Pessoa a = new Pessoa();
            Console.Write("Digite sua altura em metros: ");
            a.altura = float.Parse(Console.ReadLine());
            Console.Write("Digite seu peso em kg: ");
            a.peso = float.Parse(Console.ReadLine());
            Console.WriteLine($"Altura: {a.altura}, Peso: {a.peso}");
            a.Calculo();
        }
    }
}