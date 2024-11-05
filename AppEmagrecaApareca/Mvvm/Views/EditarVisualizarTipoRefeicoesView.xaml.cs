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
        //_Id = tipoRefeicoes.Id;
        //DsTipoRefeicao.Text = tipoRefeicoes.DsTipoRefeicao;
        BindingContext = new EditarVisualizarTipoRefeicoesViewModel(tipoRefeicoes);
    }

    private async void OnClickCadastrar(object sender, EventArgs e)
	{
		var Contexto = App._Contexto;

		if (_Id==0)
		{
			TipoRefeicao tipoRefeicoes = new TipoRefeicao();
			tipoRefeicoes.DsTipoRefeicao = DsTipoRefeicao.Text;
			tipoRefeicoes.Id = _Id;

			Contexto.Add(tipoRefeicoes);

		}
		else
		{
			var obj = Contexto.TipoRefeicoes.Where(s => s.Id == _Id).FirstOrDefault();
			obj.DsTipoRefeicao = DsTipoRefeicao.Text;
			Contexto.Entry(obj).State = EntityState.Modified;


        }
		Contexto.SaveChanges();
		await DisplayAlert("Registro salvo", "Lançamento salvo com sucesso!", "OK");
		await Navigation.PushAsync(new TipoRefeicoesView());

	}

}