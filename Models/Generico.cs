using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace projeto_csharp.Models
{
    public class Generico
    {
        public void ImprimeDados()
        {

            /*CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            decimal valor = 1582.40M;*/

            /*
                se eu coloco somente esse trecho "C" com ou sem numero ele reperesenta somente a formatação
                de valor monetário(corrency) da configuração acima, com o número logo a frente ele
                reperesenta as casas decimais, co "CurrentInfo...." ele represeta uma personalização pontual
                do tipo de moeda 'Dolar'
            */
            /*Console.WriteLine(valor.ToString("C8", CultureInfo.CreateSpecificCulture("en-US")));

            Console.WriteLine(valor.ToString("C8"));

            Console.WriteLine(valor.ToString("N3"));

            Console.WriteLine(valor.ToString("N"));

            valor = .15M;

            Console.WriteLine(valor.ToString("P"));

            int numero = 121212;

            Console.WriteLine(numero.ToString("##-##-##"));*/

            DateTime dataAtual = DateTime.Now;

            //horas em formato 24:00
            Console.WriteLine(dataAtual.ToString("dd/MM/yyy HH:mm"));

            //horas em formato AM/PM (hh)
            Console.WriteLine(dataAtual.ToString("dd/MM/yyy hh:mm"));

            //ToShortDateString mostra somente a data
            Console.WriteLine(dataAtual.ToShortDateString());

            //ToShortTimeString mostra somente a hora
            Console.WriteLine(dataAtual.ToShortTimeString());

            DateTime dataTentativa = DateTime.Parse("19/10/1969");

            Console.WriteLine(dataTentativa.ToShortDateString());

            string dataVarivel = "2020-12-17 14:00";

            //tenta fazer o Parse e retorna uma data "01/01/0001 00:00:00" mesmo se não conseguir
            DateTime.TryParseExact(
                dataVarivel,
                "yyyy-MM-dd HH:mm",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime data
            );

            Console.WriteLine(data);
        }

        public void LeituraArquivo()
        {

            try
            {
                string[] linhasArquivo = File.ReadAllLines("Arquivos/documentForRead.txt");

                foreach (var item in linhasArquivo)
                {
                    Console.WriteLine(item);
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine($"Arquivo não encontrado - {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro genérico - {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Chegou até aqui");
            }
        }

        public void MetodoComExcecao(){

            try
            {
                throw new Exception("Aqui Aconteceu Exceção");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }

        public void ManipulandoFila()
        {
            Queue<int> fila = new Queue<int>();

            fila.Enqueue(2);
            fila.Enqueue(9);
            fila.Enqueue(69);
            fila.Enqueue(231);

            foreach (int itemFila in fila)
            {
                Console.WriteLine(itemFila);
            }

            Console.WriteLine("Fim imprime fila");

            Console.WriteLine("Remove um elemento da fila");

            fila.Dequeue();

            fila.Enqueue(10);

            Console.WriteLine("insere mais uma elemento na fila");

            Console.WriteLine("Inicio imprime fila (2)");

            foreach (int itemFila in fila)
            {
                Console.WriteLine(itemFila);
            }

            Console.WriteLine("Fim imprime fila (2)");
        }

    }
}