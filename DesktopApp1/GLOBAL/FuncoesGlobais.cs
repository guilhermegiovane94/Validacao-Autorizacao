using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    class FuncoesGlobais
    {
        public static string retornaRoot()
        {
            //caminho para pasta bin do projeto  
            var diretorioBin = Environment.CurrentDirectory;
            string[] oldpath = diretorioBin.Split('\\');
            //retorna duas pastas para pasta raiz do projeto
            string[] newPath = new string[oldpath.Length - 2];
            for (var i = 0; i < (oldpath.Length - 2); i++)
            {
                //cria um novo caminho para pasta raiz
                newPath[i] = oldpath[i];
            }
            //formata caminho
            return  String.Join("\\", newPath);
        }

        public static void checkDirectory(string path,string directoryName)
        {
            bool exists = System.IO.Directory.Exists($"{path}\\{directoryName}");

            if (!exists)
                System.IO.Directory.CreateDirectory($"{path}\\{directoryName}");
        }

        public static string getLogPath()
        {
            string path = retornaRoot();

            return $"{path}\\LOGS\\";
        }

        public static string getEvidenciaPath()
        {
            string path = retornaRoot();

            return $"{path}\\EVIDENCIAS\\";
        }

        public static string tipoBit(string linha, int length)
        {
            int index = linha.IndexOf(':');
            if (index > -1)
            {
                string tipoBit = linha.Substring(index - length, length);

                //verifica se no dicionario de bits esse bit encontrado existe 
                foreach (string bit in VariaveisGlobais.bits)
                {
                    if (bit == tipoBit)
                    {
                        // return montaBit(tipoBit.Trim());

                        return tipoBit.Trim();
                    }
                }
            }

            return "";

        }

        public static string tipoTransacao(string linha, int length)
        {
            //depois do : quantos caracteres devem ser desconsiderados
            int offset = 2;
            string tipoTransacao = linha.Substring(linha.IndexOf(":") + offset, length);


            return tipoTransacao.Trim();
        }

        public static string montaBit(string intBit)
        {
            //função pra retornar string nome do bit formatado bit:002
            return String.Concat("bit:", intBit);
        }

        public static string valorBit(string linha, int length = 70)
        {
            //pega o valor do bit apos : 
            string valorBit = linha.Substring(linha.IndexOf(':') + 1, length);

            return valorBit.Trim();
        }

        public static void imprimeBit(Bit bit)
        {
            if (bit != null)
                MessageBox.Show(String.Format("tipo {0}  valor {1}", bit.tipoBit, bit.valorBit));
        }

        public static bool isEnvio(Transacao trans)
        {
            if (trans.getBit("039") != null)
            {
                return false;
            }
                return true;
           
        }


        public static string getFullNSU()
        {
            return String.Concat(VariaveisGlobais.fullnsu, VariaveisGlobais.nsu);
        }


        public static void imprimirErros()
        {
            foreach (var item in VariaveisGlobais.erros)
            {
                MessageBox.Show(item);
            }
        }

        public static void imprimirIdenticadoresTransacao()
        {
            foreach (var item in VariaveisGlobais.identificadoresTransacao)
            {
                MessageBox.Show(item.ToString());
            }
        }

    }
}
