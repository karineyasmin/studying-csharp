namespace oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animais = new Animal[3];
            animais[0] = new Ave("pardal");
            animais[1] = new Macaco("gorila");
            animais[2] = new Peixe("espada");

            foreach(Animal a in animais)
            {
                MoverAnimal(a);
            }

            Console.ReadKey();
        }
            public static void MoverAnimal(Animal animal)
            {
            //     if (animal.Tipo == "peixe")
            //     {
            //         Console.WriteLine("Peixe nadando...");

            //     }
            //     else if (animal.Tipo == "macaco")
            //     {
            //         Console.WriteLine("Macaco andando...");
            //     }
            //     else 
            //     {
            //         Console.WriteLine("Ave voando...");
            //     }
            // }
            Console.WriteLine(animal.Tipo);
            animal.Mover();
        }

    public class Animal 
    {
        public string Tipo { get; set; }
        public Animal(string tipo)
        {
            Tipo = tipo;
        }

        // virtual -> permite a reescrita
        public virtual void Mover()
        {

        }

    }

    public class Peixe : Animal 
    {
        public Peixe(string tipoAnimal) : base(tipoAnimal)
        {

        }

        public override void Mover()
        {
            Console.WriteLine("Nadar dez metros");
        }


    }

    public class Macaco : Animal
    {
        public Macaco(string tipoAnimal) : base(tipoAnimal)
        {

        }

        public override void Mover()
        {
            Console.WriteLine("Andar 10 metros");
        }

    }

    public class Ave : Animal
    {
        public Ave(string tipoAnimal) : base(tipoAnimal)
        {

        }
        public override void Mover()
        {
            Console.WriteLine("Voar 10 metros");
        }

    }

    }
}