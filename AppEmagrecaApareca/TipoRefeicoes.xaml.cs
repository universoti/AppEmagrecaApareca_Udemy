using AppEmagrecaApareca.Models;

namespace AppEmagrecaApareca;

public partial class TipoRefeicoes : ContentPage
{
	public TipoRefeicoes()
	{
		InitializeComponent();
		lTipoRefeicoes.ItemsSource = App._Contexto.TipoRefeicoes;

    }

	private async void OnClickCadastrar(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new EditarVisualizarTipoRefeicoes());
	}

    private async void OnAlterar(object sender, EventArgs e)
    {
		var item = lTipoRefeicoes.SelectedItem as TipoRefeicao;

		if (item!=null)
		{
            await Navigation.PushAsync(new EditarVisualizarTipoRefeicoes(item));
        }
		
    }

    private async void OnInicio(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TelaInicio());

    }
}