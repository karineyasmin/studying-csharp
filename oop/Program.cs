namespace oop
{

    class Program
    {
        static void Main(string[] args)
        {
            Carro fusca = new("preto", "1300");
            Carro celta = new("prata");

            fusca.Cor = "amarelo";
            fusca.Modelo = "1600";

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