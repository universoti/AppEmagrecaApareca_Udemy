using AppEmagrecaApareca.Mvvm.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Mvvm.ViewModels
{
    public partial class TipoRefeicoesViewModel:ObservableObject
    {
        [ObservableProperty]
        private bool _isRefreshing;
        public List<TipoRefeicao> ListarTipoRefeicao {  get; set; }
        public TipoRefeicoesViewModel() 
        {
            ListarTipoRefeicao= App._Contexto.TipoRefeicoes.ToList();
        }
        [RelayCommand]
        public void AtualizarTela()
        {
            ListarTipoRefeicao = App._Contexto.TipoRefeicoes.ToList();
            IsRefreshing = false;
        }
    }
}
