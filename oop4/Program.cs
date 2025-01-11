namespace oop4
{
    class Program
    {
        static void Main(string[] args) 
        {
            Quadrado quadrado = new();

            quadrado.CalcularArea();
            quadrado.CalcularPerimetro();
            quadrado.Descricao();
        }
    }
}