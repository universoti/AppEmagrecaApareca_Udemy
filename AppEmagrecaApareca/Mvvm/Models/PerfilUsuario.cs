using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Mvvm.Models
{
    public class PerfilUsuario
    {
        [Key]  //identifica uma chave no atribuito de referencia e server para gerar a pk no entity
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   //serve pra gerar chave automatica
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public int IdSexo { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public decimal RecomendacaoCalorica { get; set; }
        public decimal RecomendacaoPeso { get; set; }


    }
}
