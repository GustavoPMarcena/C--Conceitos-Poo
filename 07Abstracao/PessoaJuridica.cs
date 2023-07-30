using System;

class PessoaJuridica : Gastos 
{
    public override void taxaEmprestimo(double salario)
    {
        Console.WriteLine($"Taxa de emprestimo pessoa Juridica: {salario * 0.2}");
    }
}