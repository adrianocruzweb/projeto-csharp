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



            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}