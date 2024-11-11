using AppEmagrecaApareca.Mvvm.Models;
using AppEmagrecaApareca.Mvvm.ViewModels;

namespace AppEmagrecaApareca;

public partial class ProdutosView : ContentPage
{
	public ProdutosView()
	{
		InitializeComponent();
		//lprodutos.ItemsSource = App._Contexto.Produtos;
		BindingContext = new ProdutosViewModel();

    }


	private async void OnAlterar(object sender, EventArgs e)
	{
		var item = lprodutos.SelectedItem as Produto;
		if (item != null)
		{
			await Navigation.PushAsync(new EditarVisualizarProdutoView(item));
		}
	}

    private async void OnClickCadastrar(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new EditarVisualizarProdutoView());
        
    }

    private async void OnInicio(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TelaInicioView());
    }

	private async void AtualizaLista(object sender, EventArgs e)
	{
        BindingContext = new ProdutosViewModel();
    }

}