using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Mvvm.Models
{
    public class SelectItemProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public double Quantidade { get; set; }
        public string Unidade { get; set; }
        public double Calorias { get; set; }
        public int Indice { get; set; }

    }
}
