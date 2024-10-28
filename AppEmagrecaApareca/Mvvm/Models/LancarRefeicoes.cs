using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Mvvm.Models
{
    public class LancarRefeicoes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Iproduto { get; set; }
        public string DescricaoProduto { get; set; }

        public int IdTipoRefeicao { get; set; }
        public string DescricaoRefeicao { get; set; }

        public double QuantidadeLanc { get; set; }

        public double Calorias { get; set; }
        public DateTime datalanc { get; set; }
    }
}
