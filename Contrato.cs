using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public class Contrato : IImprimir
    {
        public void Imprimir()
        {
            Console.WriteLine("Este documento foi impresso");
        }
    }
}