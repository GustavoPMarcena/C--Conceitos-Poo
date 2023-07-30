using System;

namespace Abstracao // Usando herança no c#
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstração");

            PessoaFisica PF = new PessoaFisica();
            PF.taxaEmprestimo(1000);

            PessoaJuridica PJ = new PessoaJuridica();
            PJ.taxaEmprestimo(1000);
            
        }
    }
}