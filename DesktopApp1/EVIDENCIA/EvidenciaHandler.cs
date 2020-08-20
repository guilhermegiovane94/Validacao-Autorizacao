using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp1
{
    class EvidenciaHandler
    {
        List<string> linhas = new List<string>();

        public bool ReadDirectory()
        {
            bool retorno = false;
            //in directory find .seq files
            foreach (string filePath in Directory.GetFiles(FuncoesGlobais.getLogPath(), "*.SEQ"))
            {
                //get file name and convert into a array
                string[] fileNameArray = filePath.Split('\\');
                //file name is the last position of array
                string fileName = fileNameArray[fileNameArray.Length - 1];

                //if file name contains the specific date
                if (fileName.Contains(VariaveisGlobais.dataLog))
                {
                    //get the path of file to read 
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            //salva na variavel cada linha do arquivo
                            string linha = reader.ReadLine();


                            if (linha.Contains(FuncoesGlobais.getFullNSU()))
                            {
                                int index = linha.LastIndexOf(VariaveisGlobais.nsu);
                                if (linha.Substring(index, 7).Trim() == VariaveisGlobais.nsu.Trim()) {
                                    while (!linha.Contains(VariaveisGlobais.breakLine))
                                    {
                                        if (linha.Contains(FuncoesGlobais.getFullNSU()))
                                            linhas.Add("");
                                        //adiciona a lista as linhas da transacao ate ACTR
                                        linhas.Add(linha);
                                        //get next line
                                        linha = reader.ReadLine();
                                    }
                                    generateFile(filePath);
                                    retorno = true;
                                }                                
                            }
                        }
                    }
                }
            }
            return retorno;
        }

        public void generateFile(string filePath)
        {
            //split na localizacao do arquivo pra pegar o nome
            string[] arquivo = filePath.Split('\\');
            //formata o nome do arquivo
            string evidenciaNome = String.Format("{0}\\NSU_{1}_{2}.txt", FuncoesGlobais.getEvidenciaPath(), VariaveisGlobais.nsu, arquivo[arquivo.Length -1 ].Replace(".SEQ",""));

            //escreve no arquivo os linhas da lista
            using (StreamWriter writer = new StreamWriter(evidenciaNome))
            {
                foreach (var item in linhas)
                {
                    writer.WriteLine(item);
                }

                // lista.Clear();
            }
        }
    }
}
