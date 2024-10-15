using AppEmagrecaApareca.Util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;


namespace AppEmagrecaApareca.Models
{
    public class BancoContexto:DbContext
    {
        public DbSet<Carro> Carros { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuarios { get; set; }
        public DbSet<TipoRefeicao> TipoRefeicoes { get; set; }

        public DbSet<Produto> Produtos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conDb = $"Filename={ConexaoDb.RetornaRota("BancoApp3.db")}";
            optionsBuilder.UseSqlite(conDb);    
        }

    }
}
