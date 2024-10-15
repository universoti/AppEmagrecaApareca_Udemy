using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Util
{
    public class ConexaoDb
    {
        public static string RetornaRota(string NomeBasedados)
        {
            string rotaBaseDados = string.Empty;
            rotaBaseDados=Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            rotaBaseDados = Path.Combine(rotaBaseDados, NomeBasedados);

            return rotaBaseDados;
        }

    }
}
