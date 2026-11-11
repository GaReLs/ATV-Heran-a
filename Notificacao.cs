using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public abstract class Notificacao
    {
        public virtual void Enviar()
        {
            Console.WriteLine("Meio da notificação não enviado");
        }
        
    }
}