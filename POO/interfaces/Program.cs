using Microsoft.VisualBasic;

namespace interfaces;

    class Program
    {
        static void Main(string[] args)
        {
            Dicionario dicionario = new("asa");
            var result = dicionario.Procurar();


            foreach(string termo in result)
            {
                Console.WriteLine(termo);
            }

        }
    }

    class Buscador : IBuscador
    {
        public List<string> BuscaResultado(string criterio)
        {
            var itens = new List<String> {"Futebol", "Azul", "TEclado", "Casa", "Cachorro"};
            var resultado = itens.Where(e => e.Contains(criterio)).ToList();
            return resultado;
        }
    }

    class BuscadorTime : IBuscador
    {
        public List<string> BuscaResultado(string criterio)
        {
            var itens = new List<string> {"São Paulo", "Santos", "Portuguesa"};

            var resultado = itens.Where(e => e.Contains(criterio)).ToList();
            return resultado;
        }
    }

    class Dicionario 
    {
        private string Criterio { get;set; }

        public Dicionario(string criterio)
        {
            Criterio = criterio;
        }

        public List<string> Procurar()
        {
            IBuscador buscador = new Buscador();
            return buscador.BuscaResultado(Criterio);
        }
    }

    interface IBuscador
    {
        List<string> BuscaResultado(string criterio);

    }