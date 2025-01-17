namespace oop;

public class Carro
{
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Velocidade { get; set; }

    // Construtores
    public Carro(string cor, string modelo)
    {
        Cor = cor;
        Modelo = modelo;

    }

    public Carro(string cor)
    {
        Cor = cor;
    }

    // modificadores de acesso
    // private - o acesso é feito apenas de dentro da própria classe
    // public - o acesso é permitido de qualquer parte do código
    // internal - o acesso é permitido apenas de dentro do assembly
    // protected - o acesso é permitido apenas a classe e as classes derivadas

    public void Acelerar()
    {
        Console.WriteLine("Carro acelerando...");
        Velocidade += 1;
    }

    public void Frear()
    {
        Console.WriteLine("Carro freando...");
        Velocidade -= 1;
    }

    public int ConsultarVelocidade()
    {
        return Velocidade;
    }

    public void Virar(string direcao)
    {
        Console.WriteLine($"Carro virando para a {direcao}");
    }

    public void Parar()
    {
        while (Velocidade > 0)
        {
            Velocidade -= 1;
        }

        Console.WriteLine("Carro parado");
    }


}
