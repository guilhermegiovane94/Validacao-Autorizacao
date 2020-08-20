using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1.VALIDA
{
    class IdentificaTransacao
    {

        public void identifica(Transacoes transacoes)
        {
           // string retorno = "";
            List<string> listaTransacoes = new List<string>();

            //se a quantia de transacoes for 4 
            if (transacoes.listaTransacoes.Count <= 4)
            {
                List<string> venda = new List<string>() { "00", "0100", "0110", "00" };
                List<string> venda_negada = new List<string>() { "00", "0100", "0110", "57" };
                for (int i = 0; i < 4; i++)
                {
                    //lista de tipos de pernas
                    listaTransacoes.Add(transacoes.listaTransacoes.ElementAt(i).retornaTipoTransacao());
                }


                if (Enumerable.SequenceEqual(listaTransacoes.OrderBy(t => t), venda.OrderBy(t => t)))
                {
                    //se lista de venda for igual a lista de transacoes enviadas
                    VariaveisGlobais.identificadoresTransacao.Add("tipo","VENDA");
                    //validaVenda(transacoes.listaTransacoes);
                }
                else if (Enumerable.SequenceEqual(listaTransacoes.OrderBy(t => t), venda_negada.OrderBy(t => t)))
                {
                    VariaveisGlobais.identificadoresTransacao.Add("tipo", "VENDA NEGADA");
                    //validaVenda(transacoes.listaTransacoes);
                }
                else
                {
                    MessageBox.Show("Transação de venda faltando pernas");
                }

            }


            //se transacoes tiverem entre 4 a 9 pernas
            else if (transacoes.listaTransacoes.Count > 4 && transacoes.listaTransacoes.Count <= 8)
            {
                List<string> estorno = new List<string>() { "00", "0100", "0110", "00", "00", "0400", "0410", "00" };
                List<string> desfazimento = new List<string>() { "00", "0100", "0110", "00", "00", "0420", "0430", "00" };

                for (int i = 0; i < 4; i++)
                {
                    //lista de pernas de 0 - 4
                    listaTransacoes.Add(transacoes.listaTransacoes.ElementAt(i).retornaTipoTransacao());
                }
                for (int i = 4; i < 8; i++)
                {
                    //lista de pernas de 4 - 8
                    listaTransacoes.Add(transacoes.listaTransacoes.ElementAt(i).retornaTipoTransacao());
                }

                if (Enumerable.SequenceEqual(listaTransacoes.OrderBy(t => t), estorno.OrderBy(t => t)))
                {
                    VariaveisGlobais.identificadoresTransacao.Add("tipo", "ESTORNO");
                    // validaVenda(transacoes.listaTransacoes.GetRange(0, 4));
                    //validaEstorno(transacoes.listaTransacoes.GetRange(4, 4));
                }
                else if (Enumerable.SequenceEqual(listaTransacoes.OrderBy(t => t), desfazimento.OrderBy(t => t)))
                {
                    VariaveisGlobais.identificadoresTransacao.Add("tipo", "DESFAZIMENTO");
                    //validaVenda(transacoes.listaTransacoes.GetRange(0, 4));
                    //validaEstorno(transacoes.listaTransacoes.GetRange(4, 4));
                }
            }


            //se transacoes tiverem entre 8 a 12 pernas
            else if (transacoes.listaTransacoes.Count > 8 && transacoes.listaTransacoes.Count <= 12)
            {
                List<string> desfazimentoEstorno = new List<string>() { "00", "0100", "0110", "00", "00", "0400", "0410", "00", "00", "0420", "0430", "00" };

                for (int i = 0; i < 12; i++)
                {
                    //lista de pernas de 0 - 12
                    listaTransacoes.Add(transacoes.listaTransacoes.ElementAt(i).retornaTipoTransacao());
                }

                if (Enumerable.SequenceEqual(listaTransacoes.OrderBy(t => t), desfazimentoEstorno.OrderBy(t => t)))
                {
                    VariaveisGlobais.identificadoresTransacao.Add("tipo", "DESFAZIMENTO DE ESTORNO");
                    //validaVenda(transacoes.listaTransacoes.GetRange(0, 4));
                    //validaEstorno(transacoes.listaTransacoes.GetRange(4, 4));
                    //validaDesfazimento();
                }
            }


            //return listaTransacoes;
        }
    }
}
