using System;


internal class Pessoa    // Classe para calcular o imc usando programação orientada a objetos
{
    public float altura, peso;
    
    public float Imc()
    {
        return peso/(altura*altura);
    }

    public void Resultado(float imc)
    {
        if(imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso!");
        } 
        else if (imc > 18.5 && imc < 25)
        {
            Console.WriteLine("Peso normal!");
        } 
        else if (imc > 25 && imc < 30)
        {
            Console.WriteLine("Acima do peso");
        } 
        else if (imc > 30 && imc < 35)
        {
            Console.WriteLine("Obesidade I");
        } 
        else if (imc > 35 && imc < 40)
        {
            Console.WriteLine("Obesidade II");
        } 
        else 
        {
            Console.WriteLine("Obesidade III");
        }
    }
 
    public void Calculo()      // Chama as outras funções da classe
    {
        float imc = Imc();
        Console.WriteLine("Você está ");
        Resultado(imc);
    }


}