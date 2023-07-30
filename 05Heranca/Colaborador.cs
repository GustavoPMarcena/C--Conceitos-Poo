using System;

class Colaborador : Pessoa   //     Exemplo de herança
{
    private double salario;

    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;       // nome e idade são da classe pessoa que foi heradada
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();     // esse método também é da classe pessoa
        mensagemColaborador();
    }


    private void mensagemColaborador()
    {
        Console.WriteLine($"Salario: {salario}");
    }
}


