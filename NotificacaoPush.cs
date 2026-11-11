using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public class NotificacaoPush : Notificacao
    {
         public override void Enviar()
        {
            Console.WriteLine("Notificação enviada por Push");
        }
    }
}