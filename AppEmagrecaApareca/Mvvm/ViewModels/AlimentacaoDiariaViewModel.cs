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
    public partial class AlimentacaoDiariaViewModel: ObservableObject
    {
        public List<LancarRefeicoes> lancarRefeicoes { get; set; }

        public AlimentacaoDiariaViewModel()
        {
            lancarRefeicoes = App._Contexto.LancarRefeicoes.Where(s => s.datalanc >= DateTime.Now.Date).ToList();
        }
        [ObservableProperty]
        private bool _isRefreshing;
        [RelayCommand]
        public void AtualizarTela()
        {
            lancarRefeicoes = App._Contexto.LancarRefeicoes.Where(s => s.datalanc >= DateTime.Now.Date).ToList();
            IsRefreshing = false;
        }

    }
}
