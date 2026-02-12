using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMercado.Models
{
    public class Produto
    {
        public Produto() 
        {
        
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeParaAdicionarNoEstoque { get; set; }
        public decimal PrecoCompra {  get; set; }
        public decimal PrecoVenda { get; set; }


    }
}
