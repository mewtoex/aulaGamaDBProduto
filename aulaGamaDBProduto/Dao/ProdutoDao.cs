﻿using aulaGamaDBProduto.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace aulaGamaDBProduto.Dao
{
    public class ProdutoDao
    {
        private static DBClass DBClass;
        public static produto Adicionar(produto lProduto)
        {
            DBClass = new DBClass();
            DBClass.db.produtoes.Add(lProduto);
            DBClass.db.SaveChanges();




            return lProduto;
        }
        public static List<produto> ConsultarAll()
        {

            DBClass = new DBClass();
            return  DBClass.db.produtoes.ToList();          
        }
        public static produto Consultar(int id)
        {
            DBClass = new DBClass();
            return DBClass.db.produtoes.SingleOrDefault(lAux => lAux.IdProduto == id);
            
        }
        public static produto Alterar(produto lProduto)
        {
            DBClass = new DBClass();
            var lAuxProduto = DBClass.db.produtoes.SingleOrDefault(lAux => lAux.IdProduto == lProduto.IdProduto);
            if (lAuxProduto != null)
            {
                lAuxProduto = lProduto;
                DBClass.db.SaveChanges();
            }
            return lAuxProduto;
        }
        public static produto Apagar(produto lProduto)
        {
            DBClass = new DBClass();
            var lAuxProduto = DBClass.db.produtoes.SingleOrDefault(lAux => lAux.IdProduto == lProduto.IdProduto);
            if (lAuxProduto != null)
            {
                DBClass.db.produtoes.Remove(lAuxProduto);
                DBClass.db.SaveChanges();
            }
            return lProduto;
        }


    }
}
