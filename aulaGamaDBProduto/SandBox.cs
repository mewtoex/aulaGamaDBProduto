using aulaGamaDBProduto.Dao;
using aulaGamaDBProduto.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaGamaDBProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = ProdutoTeste.ConsultarAllProduto();
            var k2 = ProdutoTeste.ConsultaProdutoId(1);
            using (var db = new gamaProdutoEntities())
            {

            }


        }
    }
}
