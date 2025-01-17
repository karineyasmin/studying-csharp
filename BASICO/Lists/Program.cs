namespace Lists;


class Program 
{
    static void Main() 
    {

        List<string> lista;
        lista = new List<string>();

        List<int> lista1 = new List<int>();
        var lista2= new List<float>();
        List<string> lista3 = new();
\

        lista3.Add("Azul");
        lista3.Add("Amarelo");

        List<string> listaNomes = new()
        {
            "Paulo", "Maria", "Bia", "Pedro"
        };
        
    }
}