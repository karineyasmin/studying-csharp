namespace oop
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro fusca = new();


            fusca.modelo = "1300";
            fusca.cor = "Preto";

            fusca.Acelerar();
            fusca.Acelerar();

            var velocidade = fusca.ConsultarVelocidade();
            Console.WriteLine($"A velocidade atual é de {velocidade} km/h");
            fusca.Frear();
            fusca.Virar("direita");
            fusca.Acelerar();
            fusca.Frear();
            fusca.Virar("esquerda");
            fusca.Parar();

            Console.ReadKey();

        }
    }

}