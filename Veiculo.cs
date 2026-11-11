using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public abstract class Veiculo
    {
        public string Marca { get; set; }
        
        public string Modelo { get; set; }
        
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Este é o modelo: {Modelo}");
            Console.WriteLine($"Esta é a marca: {Marca}");
        }
    }
}