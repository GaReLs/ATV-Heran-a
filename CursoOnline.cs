using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria {get; set;}

        public CursoOnline()
        {
            
        }
        public CursoOnline(string nome, decimal preco , int cargaHoraria): base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
            Console.WriteLine($"e tem essa {CargaHoraria} horas carga horaria");
        }
    }
}