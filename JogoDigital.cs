using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public class JogoDigital : Jogo
    {
        string Loja {get; set;}

        public JogoDigital(string loja)
        {
            Loja = loja;
        }

        public void Informacoes()
        {
            Plataforma = Loja;
            Console.WriteLine($"Este é o nome do jogo : {Nome}");
            Console.WriteLine($"esta é a paltaforma do jogo: {Plataforma}");
        }
    }
}