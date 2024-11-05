using AppEmagrecaApareca.Mvvm.Models;
using CommunityToolkit.Mvvm.ComponentModel;
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

    }
}
