using Java.Nio.Channels;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Models
{
    public class CarregaDadosAlimento
    {
        public string Nome { get; set; } = string.Empty;
        public double Quantidade { get; set; }
        public string Unidade { get; set; }
        public double Calorias { get; set; }

        public List<CarregaDadosAlimento> PopularDados()
        {
            List<CarregaDadosAlimento> alimento = new List<CarregaDadosAlimento>()
            {
               #region Grupo 1 - 20 calorias
		      new CarregaDadosAlimento(){Nome="Aface",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="Acelga",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="Aipo",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="Almeirão",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="Aspargo",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="cebola",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="erva doce",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="mostarda",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="nabo",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="pepino",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="rabanete",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="repolho",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="rucula",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="salsão",Unidade="Porcao Pires",Quantidade=1,Calorias=20},
              new CarregaDadosAlimento(){Nome="tomate",Unidade="Porcao Pires",Quantidade=1,Calorias=20},

	         #endregion
               #region grupo 2 - 35 calorias
		
              new CarregaDadosAlimento(){Nome="Abóbora",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Abóbrinha",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Acelga",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Alcachofra",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Aspargo",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Almeirão",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Beringela",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Beterraba",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Brócolis",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Broto de bambú",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Broto de feijão",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Cebola",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Cebolinha",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Cenoura",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Chuchu",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Couve",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Couve-flor",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Cogumelo",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Escarola",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Espinafre",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Ervilha fresca",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Palmito",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Pimentão",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Quiabo",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Vagem",Unidade="colheres",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Milho",Unidade="colheres",Quantidade=4,Calorias=35},

	          #endregion
               #region grupo 3 - 50 calorias
		      new CarregaDadosAlimento(){Nome="Abacate 1/4",Unidade="colheres",Quantidade=0.25,Calorias=50},
              new CarregaDadosAlimento(){Nome="Abacaxi",Unidade="fatia",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Albran",Unidade="colher sopa",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Ameixa",Unidade="unidade",Quantidade=2,Calorias=50},
              new CarregaDadosAlimento(){Nome="Amora",Unidade="unidade",Quantidade=10,Calorias=50},
              new CarregaDadosAlimento(){Nome="Aveia",Unidade="colher",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Banana nanica 1/2",Unidade="unidade",Quantidade=0.5,Calorias=50},
              new CarregaDadosAlimento(){Nome="Banana Maçã",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Banana ouro",Unidade="unidade",Quantidade=2,Calorias=50},
              new CarregaDadosAlimento(){Nome="Banana prata",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Barra de Cereais diet",Unidade="gramas",Quantidade=20,Calorias=50},
              new CarregaDadosAlimento(){Nome="Barra de cereais light",Unidade="gramas",Quantidade=20,Calorias=50},
              new CarregaDadosAlimento(){Nome="Barra de cereais 1/2",Unidade="unidade",Quantidade=0.5,Calorias=50},
              new CarregaDadosAlimento(){Nome="Caju",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Caqui",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Carambola",Unidade="unidade",Quantidade=2,Calorias=50},
              new CarregaDadosAlimento(){Nome="Cereja",Unidade="unidades",Quantidade=10,Calorias=50},
              new CarregaDadosAlimento(){Nome="Damasco",Unidade="unidades",Quantidade=2,Calorias=50},
              new CarregaDadosAlimento(){Nome="Figo",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Framboesa",Unidade="unidade",Quantidade=10,Calorias=50},
              new CarregaDadosAlimento(){Nome="fruto do conde 1/2",Unidade="unidade",Quantidade=0.5,Calorias=50},
              new CarregaDadosAlimento(){Nome="Goiaba",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Granola",Unidade="colher",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Jaboticaba",Unidade="unidades",Quantidade=10,Calorias=50},
              new CarregaDadosAlimento(){Nome="Kiwi",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Laranja",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Maçã",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Mamão",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Mamão papaia",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Manga pequena",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Maracujá",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Melancia",Unidade="fatia",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Melão",Unidade="fatias",Quantidade=2,Calorias=50},
              new CarregaDadosAlimento(){Nome="Musle",Unidade="colher",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Morango",Unidade="pires",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Pera",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Pêssego",Unidade="unidade",Quantidade=1,Calorias=50},
              new CarregaDadosAlimento(){Nome="Sucrilhos",Unidade="colher",Quantidade=1,Calorias=50},              
	         #endregion
               #region grupo 4 - 80 calorias
		       new CarregaDadosAlimento(){Nome="Arroz cozido",Unidade="colheres",Quantidade=2,Calorias=80},
               new CarregaDadosAlimento(){Nome="Arroz a grega",Unidade="colheres",Quantidade=2,Calorias=80},
               new CarregaDadosAlimento(){Nome="Arroz integral",Unidade="colheres",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Batata",Unidade="unidade",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Batata-doce",Unidade="unidade",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Biscoito doce sem recheio",Unidade="unidade",Quantidade=2,Calorias=80},
               new CarregaDadosAlimento(){Nome="Biscoito doce com recheio",Unidade="unidade",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Biscoito ClubSocial 1/2",Unidade="pacote",Quantidade=0.5,Calorias=80},
               new CarregaDadosAlimento(){Nome="Biscoito maizena",Unidade="unidades",Quantidade=3,Calorias=80},
               new CarregaDadosAlimento(){Nome="Biscoito povilho",Unidade="rosca",Quantidade=5,Calorias=80},
               new CarregaDadosAlimento(){Nome="Biscoito Wafer",Unidade="unidades",Quantidade=2,Calorias=80},
               new CarregaDadosAlimento(){Nome="Bolacha Agua",Unidade="unidades",Quantidade=3,Calorias=80},
               new CarregaDadosAlimento(){Nome="Bolcha Salgada",Unidade="unidades",Quantidade=3,Calorias=80},
               new CarregaDadosAlimento(){Nome="Canelone",Unidade="unidade",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Capeletti ou ravioli 1/2",Unidade="xicara",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Creme de milho",Unidade="colher",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Cucuz",Unidade="fatia média",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Farelo de Aveia",Unidade="colher",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Farela de trigo",Unidade="colheres",Quantidade=2,Calorias=80},
               new CarregaDadosAlimento(){Nome="Farinhas geral",Unidade="colheres",Quantidade=2,Calorias=80},
               new CarregaDadosAlimento(){Nome="Farofa",Unidade="colher",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Feijão,Ervilha,Lentilha",Unidade="colheres",Quantidade=4,Calorias=80},
               new CarregaDadosAlimento(){Nome="Feijão branco",Unidade="colheres",Quantidade=2,Calorias=80},
               new CarregaDadosAlimento(){Nome="Floco de arroz",Unidade="colher",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Floco de milho",Unidade="colher",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Fubá",Unidade="colher",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Gergilim",Unidade="colher",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Germe de trigo",Unidade="colher",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Grão de bico",Unidade="colheres",Quantidade=3,Calorias=80},
               new CarregaDadosAlimento(){Nome="Macarrao cozido",Unidade="xicara",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Maizena",Unidade="colher",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Mandioca",Unidade="pedaço",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Mandioquinha",Unidade="pedaço",Quantidade=3,Calorias=80},
               new CarregaDadosAlimento(){Nome="Milho verde",Unidade="colher sopa",Quantidade=3,Calorias=80},
               new CarregaDadosAlimento(){Nome="Pão frances 1/2",Unidade="unidade sem miolo",Quantidade=0.5,Calorias=80},
               new CarregaDadosAlimento(){Nome="Pão de forma",Unidade="fatia",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Pão integral",Unidade="fatia",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Pão de centeio",Unidade="unidade",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Pão de gluten",Unidade="unidades",Quantidade=2,Calorias=80},
               new CarregaDadosAlimento(){Nome="Pão de queijo",Unidade="unidade",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Pão de hamburguer ou hotdog",Unidade="unidade",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Pão italiano",Unidade="unidade",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Pão de leite",Unidade="fatia",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Pão sírio",Unidade="unidade",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Polenta Assada",Unidade="fatia",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="pure de batata",Unidade="colher",Quantidade=1,Calorias=80},
               new CarregaDadosAlimento(){Nome="Risoto 1 1/2 ",Unidade="colher",Quantidade=1.5,Calorias=80},
               new CarregaDadosAlimento(){Nome="Suflede queijo 1 1/2",Unidade="colher",Quantidade=1.5,Calorias=80},

	           #endregion
               #region grupo 5 - 100 calorias
		       new CarregaDadosAlimento(){Nome="Queijo Camebert",Unidade="Fatia",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Queijo Gorgozola",Unidade="fatia",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Queijo Minas",Unidade="fatia",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Mussarela de bufala",Unidade="unidade",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Mussarela",Unidade="fatia",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Parmesão",Unidade="colher",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Polenguinho",Unidade="unidade",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Queijo prato",Unidade="fatia",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Provolone",Unidade="fatia",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Queijo de sopa",Unidade="fatia",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Queijo Roquefort",Unidade="fatia",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Requeijão Light",Unidade="colher",Quantidade=3,Calorias=100},
	           #endregion
               #region grupo 6 - 100 calorias
		       new CarregaDadosAlimento(){Nome="Almondega(carne ou frango)",Unidade="unidades",Quantidade=2,Calorias=100},
               new CarregaDadosAlimento(){Nome="Aves sem pele",Unidade="porcao",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Carne gorda de vaca",Unidade="porcao",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Carne magra de vaca",Unidade="unidade",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Camarão",Unidade="pires",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Dobradinha",Unidade="pires",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Figado de boi",Unidade="bife",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Hambuguer",Unidade="unidade",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Linguiça",Unidade="unidade",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Lombo defumado",Unidade="porção",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Lula",Unidade="pires",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Marisco",Unidade="pires",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Miolo",Unidade="porção",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Miúdos",Unidade="porcão",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Omelete",Unidade="ovo",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Ostra e mexiloes",Unidade="unidade",Quantidade=5,Calorias=100},
               new CarregaDadosAlimento(){Nome="Ovo",Unidade="unidade",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Ovo de cordona",Unidade="unidades",Quantidade=4,Calorias=100},
               new CarregaDadosAlimento(){Nome="Peito de peru",Unidade="fatias",Quantidade=2,Calorias=100},
               new CarregaDadosAlimento(){Nome="Peixe fresco",Unidade="porção",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Peixe salgado ou hadock",Unidade="porção",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Polvo",Unidade="porção",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Presunto ou frios",Unidade="fatia fina",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Quibe assado",Unidade="fatia",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Quibe Cru",Unidade="porção",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Rosbife",Unidade="fatias",Quantidade=2,Calorias=100},
               new CarregaDadosAlimento(){Nome="Salsicha",Unidade="unidade",Quantidade=1,Calorias=100},
               new CarregaDadosAlimento(){Nome="Sardinha fresca",Unidade="unidades",Quantidade=5,Calorias=100},
               new CarregaDadosAlimento(){Nome="Sardinha em olho",Unidade="unidade",Quantidade=1,Calorias=100},
	           #endregion             
               #region grupo 7 - 120 calores
		
              new CarregaDadosAlimento(){Nome="Margarina",Unidade="colheres",Quantidade=2,Calorias=120},
              new CarregaDadosAlimento(){Nome="Coalhada seca 1 1/2",Unidade="colheres",Quantidade=1.5,Calorias=120},
              new CarregaDadosAlimento(){Nome="leite integral",Unidade="copo",Quantidade=4,Calorias=35},
              new CarregaDadosAlimento(){Nome="Leite integral em pó",Unidade="colheres",Quantidade=4,Calorias=120},
              new CarregaDadosAlimento(){Nome="Leite ou iorgute em pó 1 1/2",Unidade="colheres",Quantidade=1.5,Calorias=120},
              new CarregaDadosAlimento(){Nome="Leite ou iorgute desnatado 1 1/2",Unidade="copo",Quantidade=1.5,Calorias=120},
              new CarregaDadosAlimento(){Nome="Iorgute Natural 3/4",Unidade="copo",Quantidade=0.75,Calorias=120},
              new CarregaDadosAlimento(){Nome="Leite de sopa",Unidade="copo",Quantidade=1,Calorias=120},
              

	         #endregion
               #region grupo 8 - 120 calores
		
              new CarregaDadosAlimento(){Nome="Creme de palmito",Unidade="conchas",Quantidade=2,Calorias=120},
              new CarregaDadosAlimento(){Nome="Canja sem pele",Unidade="concha",Quantidade=1,Calorias=120},
              new CarregaDadosAlimento(){Nome="Creme de aspargo",Unidade="concha",Quantidade=1,Calorias=35},
              new CarregaDadosAlimento(){Nome="Creme de cebola",Unidade="conhca",Quantidade=2,Calorias=120},
              new CarregaDadosAlimento(){Nome="Creme de cogumelo",Unidade="concha",Quantidade=1,Calorias=120},
              new CarregaDadosAlimento(){Nome="Creme de ervilhas",Unidade="concha",Quantidade=1,Calorias=120},
              new CarregaDadosAlimento(){Nome="Caldo verde",Unidade="conchas",Quantidade=2,Calorias=120},
              new CarregaDadosAlimento(){Nome="Sopa de legumes",Unidade="conchas",Quantidade=2,Calorias=120},
              

	         #endregion
                
            };

            return alimento;
        }

       

    }

    public class CarregaDadosRefeicao
    {
        public string DsTipoRefeicao { get; set; }

        public List<CarregaDadosRefeicao> PopularDados()
        {
            List<CarregaDadosRefeicao> refeicoes = new List<CarregaDadosRefeicao>()
            {
                new CarregaDadosRefeicao(){DsTipoRefeicao="Café da manhã"},
                new CarregaDadosRefeicao(){DsTipoRefeicao="Lanche da manhã"},
                new CarregaDadosRefeicao(){DsTipoRefeicao="Almoço"},
                new CarregaDadosRefeicao(){DsTipoRefeicao="Jantar"},
                new CarregaDadosRefeicao(){DsTipoRefeicao="Lanche da tarde"},
                 new CarregaDadosRefeicao(){DsTipoRefeicao="Lanche da noite"}
             };

            return refeicoes;
        }


    }

    public class CarregaDadosGerais
    {
       public void PopularGeral()
        {
            BancoContexto ContextoGeral = App._Contexto;
            List<CarregaDadosAlimento> _alimento = new CarregaDadosAlimento().PopularDados();

            foreach (var item in _alimento)
            {
                Produto objproduto= new Produto()
                {
                    Calorias = item.Calorias,
                    Nome = item.Nome,
                    Quantidade = item.Quantidade,
                    Unidade = item.Unidade
                };
                ContextoGeral.Produtos.Add(objproduto);
            };
            ContextoGeral.SaveChanges();

            List<CarregaDadosRefeicao> _ref=new CarregaDadosRefeicao().PopularDados();
            foreach (var item in _ref)
            {
                TipoRefeicao objrefeicao = new TipoRefeicao()
                {
                    DsTipoRefeicao = item.DsTipoRefeicao
                };
                ContextoGeral.TipoRefeicoes.Add(objrefeicao);
            }
            ContextoGeral.SaveChanges();

        }
        
       

    }

}
