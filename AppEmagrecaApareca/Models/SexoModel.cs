namespace AppEmagrecaApareca.Models
{
    public class SexoModel
    {
        public  int  Id { get; set; }
        public string Sigla { get; set; }
        public string DsSexo { get; set; }

        public List<SexoModel> lSexo()
        {
            return new List<SexoModel>()
            {
                new SexoModel(){Id=0,Sigla="F",DsSexo="Feminino"},
                new SexoModel(){Id=1,Sigla="M",DsSexo="Masculino"}
            };

        }

    }
}
