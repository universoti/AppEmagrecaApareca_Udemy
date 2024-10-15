using AppEmagrecaApareca.Models;

namespace AppEmagrecaApareca;

public partial class Produtos : ContentPage
{
	public Produtos()
	{
		InitializeComponent();
		lprodutos.ItemsSource = App._Contexto.Produtos;
	}


	private async void OnAlterar(object sender, EventArgs e)
	{
		var item = lprodutos.SelectedItem as Produto;
		if (item != null)
		{
			await Navigation.PushAsync(new EditarVisualizarProduto(item));
		}
	}

    private async void OnClickCadastrar(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new EditarVisualizarProduto());
        
    }

    private async void OnInicio(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TelaInicio());
    }

}