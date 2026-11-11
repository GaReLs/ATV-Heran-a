using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ATV_Heranca
{
    public abstract class ProdutoDigital
    {
        public string Nome { get; set; }
        
        public decimal Preco { get; set; }
        
        public ProdutoDigital()
        {
            Console.WriteLine($"Este é o nome do produto: {Nome}");
            Console.WriteLine($"Este é o preco do produto : {Preco:C}");
        }

        public ProdutoDigital(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
            Console.WriteLine($"Este é o nome do produto: {Nome}");
            Console.WriteLine($"Este é o preco do produto : {Preco:C}");
        }

    }
}