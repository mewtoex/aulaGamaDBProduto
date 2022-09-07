using aulaGamaDBProduto.Dao;
using aulaGamaDBProduto.Funcoes;
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
            Mensagems.inicio();
            if ((bool)Acao.apagaOpcao(Leitura.lerTela()))
            {

                Mensagems.opcoes();
                Leitura.opcoes();

            }
            else
                Acao.sair();
        }
    }
}
