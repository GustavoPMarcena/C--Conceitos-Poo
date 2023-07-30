using System;

namespace Polimorfismo   //Usando Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia do estágiario
            Imposto objE = new Estagiario();
            objE.valeAlimentacao(1200);
            objE.valeTransporte(1200);
            
            //Instancia do Gerente
            Imposto objG = new Gerente();
            objG.valeAlimentacao(5000);
            objG.valeTransporte(5000);

            //Instancia do Atendente
            Imposto objA = new Atendente();
            objA.valeAlimentacao(40000);
            objA.valeTransporte(40000);


        }
    }
}