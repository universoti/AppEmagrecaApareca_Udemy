using AppEmagrecaApareca.Mvvm.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Mvvm.ViewModels
{
    public partial class PerfilUsuViewModel:ObservableObject
    {
        #region Propriedades do MVVm

        [ObservableProperty]
        private int _id;
        [ObservableProperty]
        private string _nome;
        [ObservableProperty]
        private int _idade;
        [ObservableProperty]
        private string _sexo;
        [ObservableProperty]

        private int _idSexo;
        [ObservableProperty]
        private decimal _altura;
        [ObservableProperty]
        private decimal _peso;
        [ObservableProperty]
        private decimal _recomendacaoCalorica;
        [ObservableProperty]
        private decimal _recomendacaoPeso;

        #endregion
        private int _IdPesquisar;
        public List<SexoModel> ListarSexo { get; set; }
        public PerfilUsuario CadUsuario { get; set; }   

        public PerfilUsuViewModel()
        {
            ListarSexo = new SexoModel().lSexo() ;
            ListarUsuario();
        }

        public void ListarUsuario()
        {
            var Contexto = App._Contexto;
            try
            {
                _IdPesquisar = Contexto.PerfilUsuarios.Where(s => s.Id > 0).FirstOrDefault().Id;
            }
            catch (Exception)
            {

                //throw;
            }

            if (_IdPesquisar > 0)
            {
                CadUsuario = Contexto.PerfilUsuarios.Where(s => s.Id == _IdPesquisar).FirstOrDefault();
                Altura = CadUsuario.Altura;
                Idade = CadUsuario.Idade;
                Peso = CadUsuario.Peso;
                RecomendacaoCalorica = CadUsuario.RecomendacaoCalorica;
                RecomendacaoPeso = CadUsuario.RecomendacaoPeso;
                Sexo = CadUsuario.Sexo;
                IdSexo = ListarSexo.Where(s=>s.DsSexo == Sexo).FirstOrDefault().Id;        
                Nome = CadUsuario.Nome;
                Idade = CadUsuario.Idade;

            }

        }
        [RelayCommand]
        public void SalvarAlterar(string _Sexo)
        {
           
            var Contexto = App._Contexto;


            if (_IdPesquisar != 0)
            {
                var obj = Contexto.PerfilUsuarios.Where(s => s.Id == _IdPesquisar).FirstOrDefault();
                obj.Id = _IdPesquisar;
                obj.Altura = Altura;
                obj.Idade = Idade;
                obj.Nome = Nome;
                obj.Sexo = _Sexo;
                obj.IdSexo = ListarSexo.Where(s => s.DsSexo == _Sexo).FirstOrDefault().Id;
                obj.RecomendacaoCalorica = RecomendacaoCalorica;
                obj.RecomendacaoPeso = RecomendacaoPeso;

                Contexto.Entry(obj).State = EntityState.Modified;

            }
            else
            {
                PerfilUsuario perfil = new PerfilUsuario()
                {
                    Altura = Altura,
                    Idade = Idade,
                    Nome = Nome,
                    Peso = Peso,
                    RecomendacaoCalorica = RecomendacaoCalorica,
                    RecomendacaoPeso = RecomendacaoPeso,                   
                    Sexo = _Sexo,
                    IdSexo = ListarSexo.Where(s => s.DsSexo == _Sexo).FirstOrDefault().Id

                };
                Contexto.PerfilUsuarios.Add(perfil);
            }

            Contexto.SaveChanges();

            App.Current.MainPage.DisplayAlert("Registro salvo", "Perfil salvo com sucesso!", "ok");
        }
    }
}
