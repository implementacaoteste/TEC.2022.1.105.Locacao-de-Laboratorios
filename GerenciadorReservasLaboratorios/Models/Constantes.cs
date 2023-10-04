using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Constantes
    {
        public static int IdUsuarioLogado;
        public static string StringDeConexao;
        public static string DiretorioStringConexao = "C:\\Configuracao\\";
        public static string CaminhoChavePublica = "C:\Configuracao\\ChavePublica.txt"

        public static string CaminhoChavePrivada = "C:\\Configuracao\\ChavePrivada.txt"
        public static string NomeArquivoConexao = "sgreservasConnection.config";
        public static string DiretorioArquivoLog = Environment.CurrentDirectory + "\\Logs\\";

        public static string CaminhoArquivoLog
        {
            get
            {
                Directory.CreateDirectory(DiretorioArquivoLog);
                return DiretorioArquivoLog + "Log" + DateTime.Now.Year.ToString() +
                DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00") + ".log";
            }
        }
    }
}
