using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public abstract class Jogo
    {
        public string Nome { get; set; }
        
        protected string Plataforma {get; set;}

        public Jogo()
        {
          Plataforma = "não informado";  
        }

    }
}