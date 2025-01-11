namespace oop;

public class Carro
{

    // Atributo de instância
    public string cor;
    public string modelo;
    public int velocidade;



    // modificadores de acesso
    // private - o acesso é feito apenas de dentro da própria classe
    // public - o acesso é permitido de qualquer parte do código
    // internal - o acesso é permitido apenas de dentro do assembly
    // protected - o acesso é permitido apenas a classe e as classes derivadas

    public void Acelerar()
    {
        Console.WriteLine("Carro acelerando...");
        velocidade += 1;
    }

    public void Frear()
    {
        Console.WriteLine("Carro freando...");
        velocidade -= 1;
    }

    public int ConsultarVelocidade()
    {
        return velocidade;
    }

    public void Virar(string direcao)
    {
        Console.WriteLine($"Carro virando para a {direcao}");
    }

    public void Parar()
    {
        while (velocidade > 0)
        {
            velocidade -= 1;
        }

        Console.WriteLine("Carro parado");
    }


}