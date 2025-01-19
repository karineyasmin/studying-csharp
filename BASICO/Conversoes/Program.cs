namespace Conversoes;


class Program
{
    static void Main()
    {
        // conversao implicita
        float valor = 25.8F;
        int outro = 25;

        valor = outro;

        // conversao explicita 
        int inteiro = 100;
        uint inteiroSemSinal = (uint)inteiro;


        // parse
        // metodo presente em todo tipo primitivo 
        // usado para converter um caractere ou string para um tipo qualquer
        // caso haja incompatibilidade gera erro
        int inteiro2 = int.Parse("100");


        // Convert
        // permite converter varios tipos de valor, não apenas string
        // devemos informar o tipo na chamada da conversão

        int inteiro3 = Convert.ToInt32("100");

    }
}