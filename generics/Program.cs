namespace generics;

class Program
{
    static void Main(string[]args)
    {
        Dicionario<> dic = new();


    }


}

class ObjetoExemplo<T> 
{   
    public T Informacao { get; set; }

    public void Exibir()
    {
        Console.WriteLine(Informacao);
    }
}

class Dicionario<TKey, TValue>
{
    public TKey Chave { get; set; }
    public TValue Valor {get; set;}
    public void Exibir()
    {
        Console.WriteLine($"Chave: {Chave} - Valor: {Valor}");
    }

}