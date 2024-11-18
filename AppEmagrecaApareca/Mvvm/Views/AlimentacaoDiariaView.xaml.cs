using AppEmagrecaApareca.Mvvm.Models;
using AppEmagrecaApareca.Mvvm.ViewModels;

namespace AppEmagrecaApareca;

public partial class AlimentacaoDiariaView : ContentPage
{
	public AlimentacaoDiariaView()
	{
		InitializeComponent();
		BindingContext = new AlimentacaoDiariaViewModel();
        ///lAlimentacao.ItemsSource = App._Contexto.LancarRefeicoes.Where(s=>s.datalanc>=DateTime.Now.Date).ToList();	
	}

	private async void OnAlterar(object sender, EventArgs e)
	{
        var item = lAlimentacao.SelectedItem as LancarRefeicoes;
		if (item!=null)
		{
			await Navigation.PushAsync(new EditarVisualizarAlimentacaoDiariaView(item));

		}

	}

    private async void OnClickCadastrar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditarVisualizarAlimentacaoDiariaView());
    }

    private async void OnInicio(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TelaInicioView());
    }

	private void AtualizarTela(object sender, EventArgs e)
	{
        BindingContext = new AlimentacaoDiariaViewModel();
    }
}