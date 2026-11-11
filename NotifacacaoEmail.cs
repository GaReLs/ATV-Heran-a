using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public class NotifacacaoEmail : Notificacao
    {

        public override void Enviar()
        {
            Console.WriteLine("Notificação enviada por email");
        }
    }
}