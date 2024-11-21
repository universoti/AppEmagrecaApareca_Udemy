using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Mvvm.ViewModels
{
    public partial  class SaldoCaloriasViewModel: ObservableObject
    {

        public SaldoCaloriasViewModel()
        {
            CarregarSaldos();
        }
        #region Atributos

        [ObservableProperty]
        private string _lcaloriasConsumidas;
        [ObservableProperty]
        private string _lcaloriasRecomendada;
        [ObservableProperty]
        private string _lSaldo;
        [ObservableProperty]
        private string _nporcet;

        //porcetagem da barra de progresso
        [ObservableProperty]        
        private double _porcetagem_Progress;
        //cor da barra de progresso
        [ObservableProperty]
        private Color _porcetagem_ProgressColor;
        
        [ObservableProperty]
        public bool _isRefreshing;
        #endregion
        [RelayCommand]
        private void CarregarSaldos()
        {
            var ContextoDiaro = App._Contexto;
            LcaloriasConsumidas = ContextoDiaro.LancarRefeicoes.
                                        Where(s => s.datalanc >= DateTime.Now.AddHours(-3).Date).Sum(s => s.Calorias).ToString();
            LcaloriasRecomendada = ContextoDiaro.PerfilUsuarios.FirstOrDefault().RecomendacaoCalorica.ToString();
            var saldo = ContextoDiaro.PerfilUsuarios.FirstOrDefault().RecomendacaoCalorica
                                         -
                                        (decimal)ContextoDiaro.LancarRefeicoes.
                                        Where(s => s.datalanc >= DateTime.Now.AddHours(-3).Date).Sum(s => s.Calorias);

            LSaldo = saldo.ToString();

            var porcetegem = Convert.ToDouble(LcaloriasConsumidas) / Convert.ToDouble(LcaloriasRecomendada);
            decimal _nporcet = Math.Round((decimal)(porcetegem * 100), 2);
            Nporcet = _nporcet.ToString() + "(%)";
            Porcetagem_Progress = porcetegem;

            if (_nporcet <= 70)
            {
                _porcetagem_ProgressColor = Colors.GreenYellow;
            }
            else
            if (_nporcet <= 90)
            {
                _porcetagem_ProgressColor = Colors.Orange;
            }
            else
            {
                _porcetagem_ProgressColor = Colors.Red;
            }
            IsRefreshing = false;    
        }

        [RelayCommand]
        private void Fechar()
        {
            Shell.Current.GoToAsync("//TelaInicioView");
        }

    }
}
