using DesktopApp1.VALIDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1
{
    class VendaBaseadoBit22
    {

        public void valida(Transacao trans)
        {
            Bit codProc = trans.getBit("003");
            string codproc = codProc.valorBit;

            string modEntraPart1 = null;
            string modEntraPart2 = null;

            bool isEnvio = FuncoesGlobais.isEnvio(trans);
            if (isEnvio)
            {
                Bit modEntra = trans.getBit("022");
                if (trans.retornaTipoTransacao() == "00")
                {
                    //se for um primeiro envio 00 salvar nas variaveis globais
                    ValidaVenda.codigoProcessamento = codProc;
                    ValidaVenda.modoEntrada = modEntra;
                    ValidaVenda.valor = trans.getBit("004");
                    ValidaVenda.data = trans.getBit("013");
                }

                modEntraPart1 = modEntra.valorBit.Substring(0, 2);
                modEntraPart2 = modEntra.valorBit.Substring(2, 1);
            }
            


            switch (codproc)
            {
                case "003000":
                    if (isEnvio)
                    {
                        switch (modEntraPart1)
                        {
                            case "01":
                                if(trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Manual ");
                                //TODO
                                break;
                            case "02":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Tarja magnética ");
                                //TODO
                                break;
                            case "05":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Leitor de Circuito Integrado de Cartões");
                                //TODO
                                break;
                            case "07":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","E-commerce ");
                                //TODO
                                break;
                            case "10":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Conta cartão armazenada ");
                                //TODO
                                break;
                            case "81":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Indicador de Identificador de Rádio Frequência – Tarja magnética ");
                                //TODO
                                break;
                            case "82":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Mobile Commerce (mCommerce) ");
                                //TODO
                                break;
                            case "83":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Indicador de Identificador de Rádio Frequência – Chip ");
                                //TODO
                                break;
                            case "86":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Mudança de interface Contactless  ");
                                //TODO
                                break;
                            case "85":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Fallback do chip ");
                                //TODO
                                break;

                        }
                    }
                    break;
                case "153000":
                    if (isEnvio)
                    {
                        switch (modEntraPart1)
                        {
                            case "01":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Manual ");
                                //TODO
                                break;
                            case "02":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Tarja magnética ");
                                //TODO
                                break;
                            case "05":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Leitor de Circuito Integrado de Cartões");
                                //TODO
                                break;
                            case "07":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","E-commerce ");
                                //TODO
                                break;
                            case "10":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Conta cartão armazenada ");
                                //TODO
                                break;
                            case "81":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Indicador de Identificador de Rádio Frequência – Tarja magnética ");
                                //TODO
                                break;
                            case "82":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Mobile Commerce (mCommerce) ");
                                //TODO
                                break;
                            case "83":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Indicador de Identificador de Rádio Frequência – Chip ");
                                //TODO
                                break;
                            case "86":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Mudança de interface Contactless  ");
                                //TODO
                                break;
                            case "85":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Fallback do chip ");
                                //TODO
                                break;

                        }
                    }
                    break;
                case "002000":
                    if (isEnvio)
                    {
                        switch (modEntraPart1)
                        {
                            case "01":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Manual ");
                                //TODO
                                break;
                            case "02":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Tarja magnética ");
                                //TODO
                                break;
                            case "05":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Leitor de Circuito Integrado de Cartões");
                                //TODO
                                break;
                            case "07":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","E-commerce ");
                                //TODO
                                break;
                            case "10":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Conta cartão armazenada ");
                                //TODO
                                break;
                            case "81":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Indicador de Identificador de Rádio Frequência – Tarja magnética ");
                                //TODO
                                break;
                            case "82":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Mobile Commerce (mCommerce) ");
                                //TODO
                                break;
                            case "83":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Indicador de Identificador de Rádio Frequência – Chip ");
                                //TODO
                                break;
                            case "86":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Mudança de interface Contactless  ");
                                //TODO
                                break;
                            case "85":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Fallback do chip ");
                                //TODO
                                break;

                        }
                    }
                    break;
                case "152000":
                    if (isEnvio)
                    {
                        switch (modEntraPart1)
                        {
                            case "01":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Manual ");
                                //TODO
                                break;
                            case "02":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Tarja magnética ");
                                //TODO
                                break;
                            case "05":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Leitor de Circuito Integrado de Cartões");
                                //TODO
                                break;
                            case "07":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","E-commerce ");
                                //TODO
                                break;
                            case "10":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Conta cartão armazenada ");
                                //TODO
                                break;
                            case "81":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Indicador de Identificador de Rádio Frequência – Tarja magnética ");
                                //TODO
                                break;
                            case "82":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Mobile Commerce (mCommerce) ");
                                //TODO
                                break;
                            case "83":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Indicador de Identificador de Rádio Frequência – Chip ");
                                //TODO
                                break;
                            case "86":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Mudança de interface Contactless  ");
                                //TODO
                                break;
                            case "85":
                                if (trans.retornaTipoTransacao() == "0100")
                                    VariaveisGlobais.identificadoresTransacao.Add("entrada","Fallback do chip ");
                                //TODO
                                break;

                        }
                    }
                    break;
            }

        }
    }
}
