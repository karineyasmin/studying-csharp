namespace generics;

class Program
{
    static void Main(string[]args)
    {
        Dicionario<int, string> dic = new();
        dic.Chave = 100;
        dic.Valor = "valor100";

        dic.Exibir();
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

    public void Gravar(TValue valor)
    {

    }

    class ObjetoDerivado : Dicionario<decimal, bool>
    { 
        public void Escrever()
        {
            Chave = 15.1m;
            Valor = true;

        }

    }

    class ObjetoComum
    {
        public void EscreverMensagem<T>(T mensagem)
        {
            
        }
    }
}