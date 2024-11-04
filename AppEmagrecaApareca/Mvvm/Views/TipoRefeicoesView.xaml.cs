using AppEmagrecaApareca.Mvvm.Models;
using AppEmagrecaApareca.Mvvm.ViewModels;

namespace AppEmagrecaApareca;

public partial class TipoRefeicoesView : ContentPage
{
	public TipoRefeicoesView()
	{
		InitializeComponent();
		BindingContext = new TipoRefeicoesViewModel();

		//lTipoRefeicoes.ItemsSource = App._Contexto.TipoRefeicoes;

    }

	private async void OnClickCadastrar(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new EditarVisualizarTipoRefeicoesView());
	}

    private async void OnAlterar(object sender, EventArgs e)
   {
		var item = lTipoRefeicoes.SelectedItem as TipoRefeicao;

		if (item != null)
		{
			await Navigation.PushAsync(new EditarVisualizarTipoRefeicoesView(item));
		}

	}

	private async void OnInicio(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new TelaInicioView());
        //BindingContext = new TipoRefeicoesViewModel();
        Shell.Current.GoToAsync("//TelaInicio");  ///arrumar depois não esta funcionando
    }

	private async void AtualizaLista(object sender, EventArgs e)
	{
        BindingContext = new TipoRefeicoesViewModel();
    }

}