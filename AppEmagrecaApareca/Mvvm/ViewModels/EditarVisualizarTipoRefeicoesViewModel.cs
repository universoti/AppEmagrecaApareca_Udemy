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
    public partial class EditarVisualizarTipoRefeicoesViewModel:ObservableObject
    {

        public EditarVisualizarTipoRefeicoesViewModel()
        {

        }

        public EditarVisualizarTipoRefeicoesViewModel(TipoRefeicao tipoRefeicao)
        {
            Id = tipoRefeicao.Id;
            DsTipoRefeicao = tipoRefeicao.DsTipoRefeicao;
        }

        [ObservableProperty]
        private int _id;
        [ObservableProperty]
        public string _dsTipoRefeicao;

        [ObservableProperty]
        private string _msgRetorno;

        [RelayCommand]
        private void CadastrarAtualizar()
        {
            var Contexto = App._Contexto;

            if (Id == 0)
            {
                TipoRefeicao tipoRefeicoes = new TipoRefeicao();
                tipoRefeicoes.DsTipoRefeicao = DsTipoRefeicao;
                tipoRefeicoes.Id = Id;

                Contexto.Add(tipoRefeicoes);

            }
            else
            {
                var obj = Contexto.TipoRefeicoes.Where(s => s.Id == Id).FirstOrDefault();
                obj.DsTipoRefeicao = DsTipoRefeicao;
                Contexto.Entry(obj).State = EntityState.Modified;


            }
            Contexto.SaveChanges();
            MsgRetorno = "Lançamento salvo com sucesso!";
            Shell.Current.DisplayAlert("Registro salvo", "Lançamento salvo com sucesso!", "OK");

            var stack = Shell.Current.Navigation.NavigationStack.ToArray();
            for (int i = stack.Length - 1; i > 0;i--)
            {
                Shell.Current.Navigation.RemovePage(stack[i]);
            }
            Shell.Current.GoToAsync("//TelaInicio");
        }

    }
}
