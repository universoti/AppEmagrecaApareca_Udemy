using AppEmagrecaApareca.Models;
using Microsoft.EntityFrameworkCore;

namespace AppEmagrecaApareca;

public partial class EditarVisualizarTipoRefeicoes : ContentPage
{
	private int _Id;
	public EditarVisualizarTipoRefeicoes()
	{
		InitializeComponent();
	}

    public EditarVisualizarTipoRefeicoes(TipoRefeicao tipoRefeicoes)
    {
        InitializeComponent();
		_Id = tipoRefeicoes.Id;
		DsTipoRefeicao.Text = tipoRefeicoes.DsTipoRefeicao;
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
		await DisplayAlert("Registro salvo", "Lanšamento salvo com sucesso!", "OK");
		await Navigation.PushAsync(new TipoRefeicoes());

	}

}