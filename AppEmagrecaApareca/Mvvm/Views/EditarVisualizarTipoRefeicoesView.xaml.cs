using AppEmagrecaApareca.Mvvm.Models;
using AppEmagrecaApareca.Mvvm.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace AppEmagrecaApareca;

public partial class EditarVisualizarTipoRefeicoesView : ContentPage
{
	private int _Id;
	public EditarVisualizarTipoRefeicoesView()
	{
		InitializeComponent();
		BindingContext = new EditarVisualizarTipoRefeicoesViewModel();

    }

    public EditarVisualizarTipoRefeicoesView(TipoRefeicao tipoRefeicoes)
    {
        InitializeComponent();
        
        BindingContext = new EditarVisualizarTipoRefeicoesViewModel(tipoRefeicoes);
    }

   

}