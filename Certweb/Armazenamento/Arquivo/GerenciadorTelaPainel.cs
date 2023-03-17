using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Certweb.Armazenamento.Modelo;
using Newtonsoft.Json;
namespace Certweb.Armazenamento.Arquivo
{
    public class GerenciadorTelaPainel
    {
        private static string NomeArquivo = "painel.txt";

        public static PainelModel LerDados()
        {
            string conteudoArquivo = new GerenciadorArquivos().Ler(NomeArquivo);

            if (conteudoArquivo != null)
            {
                return JsonConvert.DeserializeObject<PainelModel>(conteudoArquivo);
            }
            else
            {
                return null;
            }
        }
        public static void SalvarDados(PainelModel painelModel)
        {
            string jsonLink = JsonConvert.SerializeObject(painelModel);

            new GerenciadorArquivos().Escrever(NomeArquivo, jsonLink);
        }
    }
}
