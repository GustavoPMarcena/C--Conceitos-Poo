using System;

class Operacoes : ICalculo
{
    public void somar(int num1, int num2)
    {
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    }

    public void subtrair(int num1, int num2)
    {
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    }
}