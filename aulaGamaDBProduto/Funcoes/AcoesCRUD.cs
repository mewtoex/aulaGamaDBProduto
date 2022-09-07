using aulaGamaDBProduto.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaGamaDBProduto.Funcoes
{
    static class AcoesCRUD
    {
        public static void CRUD(string type, string cat)
        {


        }
        public static void PresitirProduto(int id)
        {
            if (id > 0)
            {

                produto p = new produto();
                Mensagems.cadastroCampo("o Nome", "");
                p.nome = Leitura.lerTela();
                Mensagems.cadastroCampo("a Armazenagem", p.nome);
                p.Armazenagem = Leitura.lerTela();
                Mensagems.cadastroCampo("o Status", p.nome);
                p.statusProduto = Leitura.lerTela();
                Mensagems.cadastroCampo("a Unidade", p.nome);
                p.unid = Leitura.lerTela();
                Mensagems.cadastroCampo("a Quantidade", p.nome);
                p.Quantidade = Leitura.lerTelaNum();
                Mensagems.cadastroCampo("o Preço Compra", p.nome);
                p.PrecoCompra = ((decimal)Leitura.lerTelaDec());
                Mensagems.cadastroCampoLucro(p.nome);
                p.PrecoLucro = Acao.valorLucro((decimal)p.PrecoCompra, Leitura.lerTela());
                p.PrecoVenda = ((decimal)p.PrecoCompra) + p.PrecoLucro;
            }
            else
            {
                var p = ProdutoDao.Consultar(id);
                Mensagems.cadastroCampo("o Nome", p.nome);
                p.nome = Leitura.lerTela();
                Mensagems.cadastroCampo("a Armazenagem", p.nome);
                p.Armazenagem = Leitura.lerTela();
                Mensagems.cadastroCampo("o Status", p.nome);
                p.statusProduto = Leitura.lerTela();
                Mensagems.cadastroCampo("a Unidade", p.nome);
                p.unid = Leitura.lerTela();
                Mensagems.cadastroCampo("a Quantidade", p.nome);
                p.Quantidade = Leitura.lerTelaNum();
                Mensagems.cadastroCampo("o Preço Compra", p.nome);
                p.PrecoCompra = ((decimal)Leitura.lerTelaDec());
                Mensagems.cadastroCampoLucro(p.nome);
                p.PrecoLucro = Acao.valorLucro((decimal)p.PrecoCompra, Leitura.lerTela());
                p.PrecoVenda = ((decimal)p.PrecoCompra) + p.PrecoLucro;
            }

        }
        public static void ApagarProduto(int id)
        {
            var p = ProdutoDao.Consultar(id);
            var op = "0";
            do
            {
                Mensagems.apagar();
                op = Leitura.lerTela();
            } while (Acao.apagaOpcao(op) == null ? true : false );
        }
        public static List<produto> mostra() => ProdutoDao.ConsultarAll();
        
    }
}
