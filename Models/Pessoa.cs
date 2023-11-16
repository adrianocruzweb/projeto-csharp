namespace projeto_csharp.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public Pessoa()
        {

        }
        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => Nome+" "+Sobrenome.ToUpper();
        public int Idade
        {
            get => _idade;


            set
            {
                if(value == null || value < 1)
                {
                    throw new ArgumentException("Idade precisa maior que 0 ou não pode ser vazia");
                }

                _idade = value;
            }

        }

        public void Apresentar()
        {
            //Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
            /*Console.WriteLine(
                $"Olá, meu nome é " +
                $"{Nome}, e tenho " +
                $"{Idade} anos"
            );*/
            Console.WriteLine($"Olá!\nMeu nome é {NomeCompleto}\nMinha idade é {Idade} anos");
        }
    }
}