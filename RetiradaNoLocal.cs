using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public class RetiradaNoLocal : Entrega
    {
        public override void CalcularFrete()
        {
            Frete = 0;
            Console.WriteLine($"Frete no valor de: {Frete}");
        }
    }
}