using AppEmagrecaApareca.Mvvm.Models;
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
    public partial class ConfiguracoesViewModel: ObservableObject
    {
        [RelayCommand]
        private void ConfiguraDadosIniciais()
        {
            BancoContexto ContextoGeral = App._Contexto;
            if (ContextoGeral.Produtos.ToList().Count < 50)
            {
                CarregaDadosGerais carrega = new CarregaDadosGerais();
                carrega.PopularGeral();
                Shell.Current.DisplayAlert("Carregado", "Dados iniciais carregados com sucesso!", "OK");
            }
            else
            {
                Shell.Current.DisplayAlert("Carregado", "Dados Carregados anteriormente!", "OK");
            }

            if (ContextoGeral.PerfilUsuarios.ToList().Count == 0)
            {
                Shell.Current.DisplayAlert("Perfil", "Para usar o sistema cadastre seu perfil!", "OK");
                Shell.Current.Navigation.PushAsync(new PerfilUsuView());
            }

        }

    }
}
