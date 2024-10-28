using AppEmagrecaApareca.Mvvm.Models;

namespace AppEmagrecaApareca;

public partial class TipoRefeicoesView : ContentPage
{
	public TipoRefeicoesView()
	{
		InitializeComponent();
		lTipoRefeicoes.ItemsSource = App._Contexto.TipoRefeicoes;

    }

	private async void OnClickCadastrar(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new EditarVisualizarTipoRefeicoesView());
	}

    private async void OnAlterar(object sender, EventArgs e)
    {
		var item = lTipoRefeicoes.SelectedItem as TipoRefeicao;

		if (item!=null)
		{
            await Navigation.PushAsync(new EditarVisualizarTipoRefeicoesView(item));
        }
		
    }

    private async void OnInicio(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TelaInicioView());

    }
}