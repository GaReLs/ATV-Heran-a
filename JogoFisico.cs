using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public class JogoFisico: Jogo
    {
        public string BrindeFisico { get; set; }
        public string PlataformaDoJogo {get; set;}

        public JogoFisico()
        {
            BrindeFisico = "Manual";
        }
        public void Informacoes()
        {
            Plataforma = PlataformaDoJogo;
            Console.WriteLine($"Este é o nome do jogo : {Nome}");
            Console.WriteLine($"esta é a paltaforma do jogo: {Plataforma}");
            Console.WriteLine($"E este é o seu brinde: {BrindeFisico}");
        }

        
        
    }
}