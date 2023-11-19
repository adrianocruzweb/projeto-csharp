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

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            decimal valor = 1582.40M;


            /*
                se eu coloco somente esse trecho "C" com ou sem numero ele reperesenta somente a formatação
                de valor monetário(corrency) da configuração acima, com o número logo a frente ele
                reperesenta as casas decimais, co "CurrentInfo...." ele represeta uma personalização pontual
                do tipo de moeda 'Dolar'
            */
            Console.WriteLine(valor.ToString("C8", CultureInfo.CreateSpecificCulture("en-US")));

            Console.WriteLine(valor.ToString("C8"));

            Console.WriteLine(valor.ToString("N3"));

            Console.WriteLine(valor.ToString("N"));

            valor = .15M;

            Console.WriteLine(valor.ToString("P"));

            int numero = 121212;

            Console.WriteLine(numero.ToString("##-##-##"));
        }
    }
}