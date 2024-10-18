using AppEmagrecaApareca.Models;

namespace AppEmagrecaApareca;

public partial class EditarVisualizarAlimentacaoDiaria : ContentPage
{
	public EditarVisualizarAlimentacaoDiaria()
	{
		InitializeComponent();
        CarregarTipos();
	}

    public EditarVisualizarAlimentacaoDiaria(LancarRefeicoes refeicoes)
    {
        InitializeComponent();
        CarregarTipos();
    }

    public void CarregarTipos()
    {
        var Contexto = App._Contexto;
        List<Produto> lprodutos = Contexto.Produtos.ToList();
        pickerAlimento.Title = "Selecione a refeição";
        pickerAlimento.ItemsSource = lprodutos.OrderBy(s => s.Nome).ToList();
        pickerAlimento.ItemDisplayBinding = new Binding("Nome");

        List<TipoRefeicao> ltipoRefeicaos = Contexto.TipoRefeicoes.ToList();
        pickerTipoRefeicao.Title = "Selecione o periodo da refeição";
        pickerTipoRefeicao.ItemsSource = ltipoRefeicaos.ToList();
        pickerTipoRefeicao.ItemDisplayBinding = new Binding("DsTipoRefeicao");
    }

    void  SelAlimento(object sender, EventArgs e)
    {
        var pickerSelAlimento=(Picker) sender;
        int selectedIndex=pickerSelAlimento.SelectedIndex;

        if (selectedIndex != -1)
        {
            Produto produto=(Produto)pickerSelAlimento.ItemsSource[selectedIndex];
            QuantidadeLanc.Text=produto.Quantidade.ToString();  
            Calorias.Text=produto.Calorias.ToString();
            var indprod = produto.Id;
        }

    }

    void SelTipoRefeicao(object sender, EventArgs e)
    {
        var picker= (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            TipoRefeicao tipo = (TipoRefeicao)picker.ItemsSource[selectedIndex];
            var ind=tipo.Id.ToString();
        }

    }

}