using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1.VALIDA
{
    class ValidaBitsObrigatorios
    {

           public  void valida(Transacao transacao)
            {
                List<string> bits_obrigatoriosIda = new List<string>() { "002", "003", "004", "007", "011", "012", "013", "014", "018", "019", "022", "024", "032", "037", "041", "042", "043", "048", "049", "058", "060", "127" };

                List<string> bits_obrigatoriosVolta = new List<string>() { "002", "003", "004", "007", "011", "012", "013", "014", "019", "032", "037", "041", "042", "043", "048", "049", "127" };

                switch (transacao.retornaTipoTransacao())
                {
                    case "0100":
                        foreach (string bit in bits_obrigatoriosIda)
                        {
                            Bit temp = transacao.getBit(bit);
                            if (temp == null)
                            {
                                VariaveisGlobais.erros.Add($"bit {bit} obrigaótio não enviado {transacao.retornaTipoTransacao()}");
                            }
                        }
                        break;
                    case "0110":
                        foreach (string bit in bits_obrigatoriosVolta)
                        {
                            Bit temp = transacao.getBit(bit);
                            if (temp == null)
                            {
                                VariaveisGlobais.erros.Add($"bit {bit} obrigaótio não enviado {transacao.retornaTipoTransacao()}");
                            }
                        }
                        break;
                    case "00":
                        foreach (string bit in bits_obrigatoriosIda)
                        {
                            Bit temp = transacao.getBit(bit);
                            if (temp == null)
                            {
                                VariaveisGlobais.erros.Add($"bit {bit} obrigatório não enviado {transacao.retornaTipoTransacao()}");
                            }
                        }
                        break;
                    case "57":
                        break;
                }
            }
        }
    
}
