namespace TipoPrimitivos
{
    class Program
    {
        static void Main()
        {   
            const string constante = "Isso é uma constante";
            byte meuByte = 127;
            // short
            int idade = 12;
            // long
            float salario = 2.500f; // float
            double salarioSemestral = 22.000;
            decimal salarioAnual = 25.000m;  //decimal
            bool ligado = false;
            bool usuarioExpirado = true;

            char letra = 'A';

            string primeiraLetra = "C";
            string texto = "Meu texto";
            var documento = "12345.99";


            var age = 54;

            object sobrenome = "Silva"; // será do tipo object -- tipo generico que recebe qualquer valor ou objeto -- não funciona o intellisense
        
            // Nullable Types

            // void - vazio - sem retorno
            // null - nulo, vazio - para definição de tipos
            int? variavel = null;
            // nulo nao imprime nada
            Console.WriteLine(variavel);

            // conversao explicita
            int inteiro = 100;
            uint interoSemSinal = (uint)inteiro;

            // Parse -- sempre espera uma string

            int inteiro2 = int.Parse("100");

            // Convert -- converte varios tipos de valor
            int inteiro3 = Convert.ToInt32("100");
            

     
        }
    }

    
}