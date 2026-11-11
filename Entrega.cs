using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public abstract class Entrega
    {
        public decimal Distancia { get; set; }
        
        protected decimal Frete {get; set;}
        public abstract void CalcularFrete();

        
    }
}