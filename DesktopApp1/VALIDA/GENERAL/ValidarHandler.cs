using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesktopApp1
{
    class ValidarHandler
    {
        Transacoes transacoes = new Transacoes();

        public bool getFile()
        {
            bool retorno = false;
            List<string> linhas = new List<string>();
            foreach (string filePath in Directory.GetFiles(FuncoesGlobais.getEvidenciaPath(), "*.txt"))
            {
                //if file nama has selected NSU
                if (filePath.Contains(VariaveisGlobais.nsu))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            //salva na variavel cada linha do arquivo
                            string linha = reader.ReadLine();
                            //find transaction
                            if (linha.Contains(FuncoesGlobais.getFullNSU()))
                            {
                                //linha = reader.ReadLine();
                                //run all lines of transaction
                                while (linha != "" && !reader.EndOfStream)
                                {
                                    //find all lines of transaction
                                    linhas.Add(linha);
                                    linha = reader.ReadLine();
                                }

                                Transacao transacao = new Transacao();
                                transacao.linhas.AddRange(linhas);
                                linhas.Clear();

                                transacoes.listaTransacoes.Add(transacao);
                                retorno = true;
                            }

                        }
                    }
                }
            }
            return retorno;
        }

        public void validar()
        {
            switch (VariaveisGlobais.versaoMensageria)
            {
                case "19.2":
                    new ValidarTransacao().validar19_2(transacoes);
                    break;

                case "20.1":
                    new ValidarTransacao().validar20_1(transacoes);
                    break;
            }
        }
    }
}

