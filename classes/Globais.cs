using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoVelhaCredi.formularios
{
    public class Globais
    {
        public static bool Logado = false;
        public static string NivelAcesso = "";
        public static string senha, confirm, conta;
        public static bool ChaveDeAcesso = false;


        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomebanco = "DATABASE_VELHACREDI.db";
        public static string caminhobanco = caminho + @"\banco\";

        public static string chavegerada = "";









    }
}
