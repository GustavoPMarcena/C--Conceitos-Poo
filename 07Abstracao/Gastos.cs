using System;

abstract class Gastos   // Classe abstrata
{
    public abstract void taxaEmprestimo(double salario);  // Método abstrato obrigatório

    public void calculaPoupanca(double salario, double taxa) // Método não obrigatório
    {
        Console.WriteLine($"Dinheiro obtido da poupança: R${salario * taxa}");
    }
}


