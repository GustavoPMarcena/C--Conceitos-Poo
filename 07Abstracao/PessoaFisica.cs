using System;

class PessoaFisica : Gastos 
{
    public override void taxaEmprestimo(double salario)
    {
        Console.WriteLine($"Taxa de emprestimo pessoa física: {salario * 0.1}");
    }
}