using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Mvvm.Models
{
    public class Carro
    {
        [Key]  //identifica uma chave no atribuito de referencia e server para gerar a pk no entity
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   //serve pra gerar chave automatica
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Ano { get; set; }
    }
}
