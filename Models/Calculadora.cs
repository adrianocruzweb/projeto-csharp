namespace projeto_csharp.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }

        public void Seno(double angulo)
        {
            double anguloRad = angulo * Math.PI / 180;
            double seno = Math.Sin(anguloRad);
            Console.WriteLine($"O seno de {angulo} é {Math.Round(seno,4)}");
        }

        public void Coseno(double angulo)
        {
            double anguloRad = angulo * Math.PI / 180;
            double cosseno = Math.Cos(anguloRad);
            Console.WriteLine($"O Cosseno de {angulo} é {Math.Round(cosseno,4)}");
        }

        public void Tangente(double angulo)
        {
            double anguloRad = angulo * Math.PI / 180;
            double tangente = Math.Tan(anguloRad);
            Console.WriteLine($"O Tangente de {angulo} é {Math.Round(tangente,4)}");
        }
    }
}