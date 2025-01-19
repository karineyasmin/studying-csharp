namespace Switch;


class Program 
{
    static void Main()
    {
        string valor = "Maria";

        switch(valor)
        {
            case "João": Console.WriteLine("Não é a pessoa!"); break;
            case "Ana": Console.WriteLine("Não é a pessoa!"); break;
            case "Maria": Console.WriteLine("É a pessoa!"); break;
            default: Console.WriteLine("Não encontrei."); break;
        }

    }    

}