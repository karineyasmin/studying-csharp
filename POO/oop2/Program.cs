namespace oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato1 = new();
            gato1.Nome = "bichano";
            gato1.Andar();   
            gato1.Miar();

            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "totó";
            cachorro1.Comer(0.5m);
            cachorro1.Latir();

            Animal animal = new();
            animal.Andar();
        }
    }
}