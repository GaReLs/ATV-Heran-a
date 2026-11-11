using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public class EntregaExpressa : Entrega
    {
        public override void CalcularFrete()
        {
            Frete = (Distancia * 10);
            Console.WriteLine($"Frete no valor de: {Frete}");
        }
    }
}