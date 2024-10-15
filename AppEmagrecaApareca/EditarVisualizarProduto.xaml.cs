using AppEmagrecaApareca.Models;
using Microsoft.EntityFrameworkCore;

namespace AppEmagrecaApareca;

public partial class EditarVisualizarProduto : ContentPage
{
	private int _Id;
	public EditarVisualizarProduto()
	{
		InitializeComponent();
	}

    public EditarVisualizarProduto(Produto produtos)
    {
        InitializeComponent();
        _Id = produtos.Id;
        Nome.Text = produtos.Nome;
        Quantidade.Text = produtos.Quantidade.ToString();
        Unidade.Text = produtos.Unidade.ToString();
        Calorias.Text = produtos.Calorias.ToString();

    }

    private async void OnClickCadastrar(object sender, EventArgs e)
	{
		var Contexto = App._Contexto;
		if (_Id==0)
		{
			Produto produto = new Produto();
            produto.Nome = Nome.Text;
            produto.Quantidade = Convert.ToInt32(Quantidade.Text);
            produto.Unidade = Unidade.Text;
            produto.Calorias = Convert.ToDouble(Calorias.Text);
            Contexto.Add(produto);

        }
		else
		{
			var obj = Contexto.Produtos.Where(s => s.Id==_Id).FirstOrDefault();
            obj.Nome = Nome.Text;
            obj.Quantidade = Convert.ToInt32(Quantidade.Text);
            obj.Unidade = Unidade.Text;
            obj.Calorias = Convert.ToDouble(Calorias.Text);
            Contexto.Entry(obj).State = EntityState.Modified;

        }

		Contexto.SaveChanges();
		await DisplayAlert("Registro salvo", "Lançamento salvo com sucesso!", "OK");
		await Navigation.PushAsync(new Produtos());
    }

}