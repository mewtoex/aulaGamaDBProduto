using aulaGamaDBProduto.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace aulaGamaDBProduto.Funcoes
{
    static class Acao
    {

        public static void limpra() => Console.Clear();
        public static void sair() => Environment.Exit(0);

        public static void repitir() => Console.Clear();
        public static void cadastraProduto(produto p) => ProdutoDao.Adicionar(p);
        public static void alterarProduto(produto p) => ProdutoDao.Alterar(p);
        public static void apagarProduto(produto p) => ProdutoDao.Apagar(p);
        public static void consultarIDProduto(int p) => ProdutoDao.Consultar(p);
        public static void consultarAllProduto() => ProdutoDao.ConsultarAll();
        public static decimal valorLucro(decimal vVenda, string lucro)
        {

            return vVenda;
        }
        public static bool? apagaOpcao(string op)
        {

            switch (op)
            {
                case ("1"):

                    return true;
                    break;
                case ("2"):
                    return false;
                    break;
                default:

                    return null;
            }
        }

        public static void Opcao(string op)
        {

            switch (op)
            {
                case ("1"):
                    AcoesCRUD.PresitirProduto(0);
                    break;
                case ("2"):
                    AcoesCRUD.mostra();//Melhorar Textos
                    break;
                case ("3"):
                    AcoesCRUD.PresitirProduto(0);//alterar
                    break;
                case ("4"):
                    AcoesCRUD.ApagarProduto(0);//apagar
                    break;
                case ("5"):
                    Acao.sair(); 
                    break;
                default:
                    Mensagems.invalida();
                    break;

            }
        }


    }




}
