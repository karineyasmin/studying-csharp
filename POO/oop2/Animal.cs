namespace oop2;

public class Animal
{
    public string Nome {get; set; }
    public int Idade {get; set; }
    public decimal Peso {get; set;}
    public string Genero {get; set;}

    public void Andar(){
        Console.WriteLine($"{Nome} está andando");
    }

    public void Comer(decimal quantidade){
        Peso += quantidade;
        Console.WriteLine($"{Nome} comeu e agora está pesando {Peso}");
    }

    public void Dormir(){
        Console.WriteLine($"{Nome} está dormindo");
    }
}
