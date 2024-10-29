using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Mvvm.ViewModels
{
    public partial class PerfilUsuViewModel:ObservableObject
    {

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


    }
}
