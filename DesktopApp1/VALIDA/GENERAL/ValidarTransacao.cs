using DesktopApp1.VALIDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    class ValidarTransacao
    {

        public void validar19_2(Transacoes transacoes)
        {
            //adiciona as variaveis globais o tipo de operacao/transacao 
            new IdentificaTransacao().identifica(transacoes);


            switch (VariaveisGlobais.identificadoresTransacao["tipo"])
            {
                case "VENDA":
                case "VENDA NEGADA":
                    new ValidaVenda().validaVenda(transacoes.listaTransacoes);
                    break;
                case "ESTORNO":
                    new ValidaEstorno().validaEstorno(transacoes.listaTransacoes);
                    break;
                case "DESFAZIMENTO":
                    new ValidaDesfazimento().validaDesfazimento(transacoes.listaTransacoes);
                    break;
                case "DESFAZIMENTO DE ESTORNO":
                   break;
                default:
                    MessageBox.Show("Operação não implementada");
                    break;
            }

            FuncoesGlobais.imprimirIdenticadoresTransacao();
            FuncoesGlobais.imprimirErros();
        }

        public void validar20_1(Transacoes transacoes)
        {
            //adiciona as variaveis globais o tipo de operacao/transacao 
            new IdentificaTransacao().identifica(transacoes);


            switch (VariaveisGlobais.identificadoresTransacao["tipo"])
            {
                case "VENDA":
                case "VENDA NEGADA":
                    new ValidaVenda().validaVenda(transacoes.listaTransacoes);
                    break;
                case "ESTORNO":
                    new ValidaEstorno().validaEstorno(transacoes.listaTransacoes);
                    break;
                case "DESFAZIMENTO":
                    new ValidaDesfazimento().validaDesfazimento(transacoes.listaTransacoes);
                    break;
                case "DESFAZIMENTO DE ESTORNO":
                    break;
                default:
                    MessageBox.Show("Operação não implementada");
                    break;
            }

            FuncoesGlobais.imprimirIdenticadoresTransacao();
            FuncoesGlobais.imprimirErros();
        }
    }
}
