using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

         public void ExibirInformacoes()
        {
            Console.WriteLine($"Este é o modelo: {Modelo}");
            Console.WriteLine($"Esta é a marca: {Marca}");
            Console.WriteLine($"esta moto tem: {Cilindradas} de cilindradas");
        }
    }
}