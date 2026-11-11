using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadeDePaginas { get; set; }

        public Ebook()
        {
            
        }
        public Ebook(string nome, decimal preco, int quantidadeDePaginas): base(nome, preco)
        {
            QuantidadeDePaginas = quantidadeDePaginas;
            Console.WriteLine($"e tem essa {QuantidadeDePaginas} quantidade de paginas");
        }
    }
}