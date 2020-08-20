using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1.VALIDA
{
    class ValidaVenda
    {
        public static Bit codigoProcessamento { set; get; }
        public static Bit valor { set; get; }
        public static Bit data { set; get; }
        public static Bit modoEntrada { set; get; }

        public void validaVenda(List<Transacao> lista, bool store = false)
        {
            ValidaBit validaBit = new ValidaBit();
            ValidaBitsObrigatorios validaBitsObrigatorios = new ValidaBitsObrigatorios();
            VendaBaseadoBit22 vendaBaseadoBit22 = new VendaBaseadoBit22();

            

                //valida pernas da venda
                foreach (Transacao transacao in lista)
                {
                    //monta a transacao e bits
                    transacao.Monta();
                    string tipo = transacao.tipoTransacao;
                    switch (tipo)
                    {
                        case "00":
                            //valida baseado no bit 22

                            if (!FuncoesGlobais.isEnvio(transacao))
                            {
                            validaBit.valida(transacao.getBit("003"), codigoProcessamento, tipo);
                            validaBit.valida(transacao.getBit("004"), valor, tipo);
                            validaBit.valida(transacao.getBit("013"), data, tipo);
                            }

                            validaBitsObrigatorios.valida(transacao);
                             vendaBaseadoBit22.valida(transacao);

                            // FuncoesGlobais.printBit(modoEntrada);
                            break;
                        case "0100":
                        validaBit.valida(transacao.getBit("003"), codigoProcessamento, tipo);
                        validaBit.valida(transacao.getBit("004"), valor, tipo);
                        validaBit.valida(transacao.getBit("013"), data, tipo);
                        validaBit.valida(transacao.getBit("022"), modoEntrada, tipo);

                            validaBitsObrigatorios.valida(transacao);
                        //valida baseado no bit 22
                        vendaBaseadoBit22.valida(transacao);

                            break;
                        case "0110":
                        validaBit.valida(transacao.getBit("003"), codigoProcessamento, tipo);
                        validaBit.valida(transacao.getBit("004"), valor, tipo);
                        validaBit.valida(transacao.getBit("013"), data, tipo);

                            //validaBit(transacao.getBit("022"), modEntra, tipo);
                            validaBitsObrigatorios.valida(transacao);
                        //valida baseado no bit 22
                        vendaBaseadoBit22.valida(transacao);

                            break;
                        case "57":
                        validaBit.valida(transacao.getBit("003"), codigoProcessamento, tipo);
                        validaBit.valida(transacao.getBit("004"), valor, tipo);
                        validaBit.valida(transacao.getBit("013"), data, tipo);

                            //validaBit(transacao.getBit("022"), modEntra, tipo);
                            validaBitsObrigatorios.valida(transacao);
                        //valida baseado no bit 22
                        vendaBaseadoBit22.valida(transacao);

                            break;
                    }
                }
                //se transacao for 400 ou 420 salva nas variaveis globais pra validacao
                if (store)
                {

                }
            }
        }
    
}
