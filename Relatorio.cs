using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public class Relatorio : IExportar, IImprimir
    {
        public void Exportar()
        {
             Console.WriteLine("Este documento foi exportado");
        }

        public void Imprimir()
        {
            Console.WriteLine("Este documento foi impresso");
        }
    }

}