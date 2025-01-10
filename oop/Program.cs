namespace oop

internal class Program
{
    static void Main(string[] args)
    {
        int valor = 1;

        Carro carro1 = new Carro();
        Carro carro2 = new();
        var carro3 = new Carro();

        carro1.cor = "Verde";
        carro2.cor = "Amarela";
        carro3.cor = "Vermelho";

        Carro.numeroDeInstancias = 2;


    }
}