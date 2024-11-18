using AppEmagrecaApareca.Mvvm.Models;
using AppEmagrecaApareca.Mvvm.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace AppEmagrecaApareca;

public partial class EditarVisualizarProdutoView : ContentPage
{
	
	public EditarVisualizarProdutoView()
	{
		InitializeComponent();
        BindingContext = new EditarVisualizarProdutoViewModel();

    }

    public EditarVisualizarProdutoView(Produto produtos)
    {
        InitializeComponent();
        BindingContext = new EditarVisualizarProdutoViewModel(produtos);
        

    }

 

}