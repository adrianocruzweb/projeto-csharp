namespace projeto_csharp.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        public int Idade { get; set; }

        public void Apresentar()
        {
            //Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
            /*Console.WriteLine(
                $"Olá, meu nome é " +
                $"{Nome}, e tenho " +
                $"{Idade} anos"
            );*/
            Console.WriteLine($"Olá!\nMeu nome é {Nome}\nMinha idade é {Idade} anos");
        }
    }
}