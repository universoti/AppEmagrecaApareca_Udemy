using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Models
{
    public class TipoRefeicao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Café da manhã,lanche da manha,almoço,jantar,lanche da tarde,lanche da noite
        /// </summary>
        public string DsTipoRefeicao { get; set; }

    }
}
