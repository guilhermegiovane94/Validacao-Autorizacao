using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1.VALIDA
{
    class ValidaBit
    {
        public void valida(Bit recebido, Bit compara, string tipoTransacao = null)
        {
            if (recebido == null)
            {
                //se o bit não for encontrado
                VariaveisGlobais.erros.Add(String.Format("ERRO bit {0} não existe, na perna {1}", compara.tipoBit, tipoTransacao));
            }
            else if (recebido.valorBit != compara.valorBit)
            {


                VariaveisGlobais.erros.Add(String.Format("ERRO no {0} valor: {1}, na perna {2}", recebido.tipoBit, recebido.valorBit, tipoTransacao));
            }
        }
    }
}
