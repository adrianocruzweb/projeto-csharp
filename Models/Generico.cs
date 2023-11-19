using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_csharp.Models
{
    public class Generico
    {
        public void ImprimeDados()
        {
            decimal valor = 82.40M;

            Console.WriteLine($"{valor:C}");
        }
    }
}