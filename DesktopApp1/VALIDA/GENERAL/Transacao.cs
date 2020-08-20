using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    class Transacao
    {
        public List<string> linhas = new List<string>();
        public string tipoTransacao { get; set; }
        public List<Bit> bits = new List<Bit>();

        
        public void geraBits()
        {
            //for each line in Transacao find corresponding bit
            foreach (string linha in linhas)
            {
                //tipo bit
                string Strbit = FuncoesGlobais.tipoBit(linha,3);
                //if return empty that bit not exists
                if(Strbit != "")
                {
                    //if bit exists set type and value
                    //value bit
                    string StrValBit = FuncoesGlobais.valorBit(linha);
                    Bit newBit = new Bit();
                    newBit.tipoBit = Strbit;
                    newBit.valorBit = StrValBit;

                    bits.Add(newBit);
                    //MessageBox.Show(String.Format("{0}  {1}",newBit.tipoBit,newBit.valorBit));
                }
            }
        }

        public string retornaTipoTransacao()
        {
            return FuncoesGlobais.tipoTransacao(linhas.ElementAt(1), 6);
        }

        public void Monta()
        {
            tipoTransacao = FuncoesGlobais.tipoTransacao(linhas.ElementAt(1), 6);
            geraBits();
        }


        public Bit getBit(String tipoBit)
        {
            //retorna primeiro encontrado ou valor default
            //valor default para objeto é null
            return bits.FirstOrDefault(a => a.tipoBit == tipoBit);

            //foreach(Bit bit in bits)
            //{
            //    if(tipoBit == bit.tipoBit)
            //    {
            //        return bit;
            //    }
            //}

            //return null;
        }

    }
}
