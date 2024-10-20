using AppEmagrecaApareca.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace AppEmagrecaApareca;

public partial class EditarVisualizarAlimentacaoDiaria : ContentPage
{
    public List<SelectItemProdutoModel> produtos { get; set; }
    public List<SelectItemTipoRefeicao> tipoRefeicaos { get; set; }
    
    private int _Id = 0;
    private int indprod = 0;
    private int indtiporefeicao = 0;
    public EditarVisualizarAlimentacaoDiaria()
	{
		InitializeComponent();
        CarregarTipos();
	}

    public EditarVisualizarAlimentacaoDiaria(LancarRefeicoes refeicoes)
    {
        InitializeComponent();
        CarregarTipos();
        pickerAlimento.SelectedIndex = produtos.Where(s => s.Id == refeicoes.Iproduto).FirstOrDefault().Indice;
        QuantidadeLanc.Text = produtos.Where(s => s.Id == refeicoes.Iproduto).FirstOrDefault().Quantidade.ToString();
        Calorias.Text = produtos.Where(s => s.Id == refeicoes.Iproduto).FirstOrDefault().Calorias.ToString();
        pickerTipoRefeicao.SelectedIndex= tipoRefeicaos.Where(s => s.Id == refeicoes.IdTipoRefeicao).FirstOrDefault().Indice;
        _Id = refeicoes.Id;
        indprod = pickerAlimento.SelectedIndex;
        indtiporefeicao = pickerTipoRefeicao.SelectedIndex;
    }

    public void CarregarTipos()
    {
        //var Contexto = App._Contexto;
        //List<Produto> lprodutos = Contexto.Produtos.ToList();
        populaSelectProduto();
        popularSelectTipoRefeicao();


        pickerAlimento.Title = "Selecione a refeição";
        pickerAlimento.ItemsSource = produtos;
            //lprodutos.OrderBy(s => s.Nome).ToList();
        pickerAlimento.ItemDisplayBinding = new Binding("Nome");

        //List<TipoRefeicao> ltipoRefeicaos = Contexto.TipoRefeicoes.ToList();
        pickerTipoRefeicao.Title = "Selecione o periodo da refeição";
        pickerTipoRefeicao.ItemsSource = tipoRefeicaos;
            //tipoRefeicaos.ToList();
        pickerTipoRefeicao.ItemDisplayBinding = new Binding("DsTipoRefeicao");
    }

    void  SelAlimento(object sender, EventArgs e)
    {
        var pickerSelAlimento=(Picker) sender;
        int selectedIndex=pickerSelAlimento.SelectedIndex;

        if (selectedIndex != -1)
        {
            //Produto produto=(Produto)pickerSelAlimento.ItemsSource[selectedIndex];
            SelectItemProdutoModel produto = (SelectItemProdutoModel)pickerSelAlimento.ItemsSource[selectedIndex];
            QuantidadeLanc.Text=produto.Quantidade.ToString();  
            Calorias.Text=produto.Calorias.ToString();
             indprod = produto.Id;
        }

    }

    void SelTipoRefeicao(object sender, EventArgs e)
    {
        var picker= (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            //TipoRefeicao tipo = (TipoRefeicao)picker.ItemsSource[selectedIndex];
            SelectItemTipoRefeicao tipo = (SelectItemTipoRefeicao)picker.ItemsSource[selectedIndex];
            indtiporefeicao = tipo.Id;
        }

    }

    public void populaSelectProduto()
    {
        produtos = new List<SelectItemProdutoModel>();
        int _indice = 0;
        var lAux = App._Contexto.Produtos.OrderBy(s => s.Nome).ToList();
        foreach (var item in lAux)
        {
            SelectItemProdutoModel select = new SelectItemProdutoModel()
            {
                Calorias = item.Calorias,
                Id = item.Id,
                Nome = item.Nome,
                Quantidade = item.Quantidade,
                Unidade = item.Unidade,
                Indice = _indice

            };
            produtos.Add(select);
            _indice++; 

        }
    }

    public void popularSelectTipoRefeicao()
    {
        tipoRefeicaos = new List<SelectItemTipoRefeicao>();
        int _indice = 0;
        var lAux = App._Contexto.TipoRefeicoes.ToList();

        foreach (var item in lAux)
        {
            SelectItemTipoRefeicao select = new SelectItemTipoRefeicao()
            {
                Id = item.Id,
                DsTipoRefeicao = item.DsTipoRefeicao,
                Indice = _indice
            };
            tipoRefeicaos.Add(select);
            _indice++;

        }

    }

    private async void OnClickCadastrar(object sender, EventArgs e)
    {
        var Contexto = App._Contexto;

        if (_Id==0)
        {
            LancarRefeicoes refeicoes = new LancarRefeicoes();
            refeicoes.Id = _Id;
            refeicoes.QuantidadeLanc = Convert.ToDouble(QuantidadeLanc.Text);
            refeicoes.DescricaoProduto = produtos.Where(s => s.Id == indprod).FirstOrDefault().Nome;
            refeicoes.DescricaoRefeicao = tipoRefeicaos.Where(s => s.Id == indtiporefeicao).FirstOrDefault().DsTipoRefeicao;
            refeicoes.Iproduto = indprod;
            refeicoes.IdTipoRefeicao = indtiporefeicao;
            refeicoes.datalanc = DateTime.Now.AddHours(-3);
            refeicoes.Calorias = Convert.ToDouble(Calorias.Text);
            Contexto.Add(refeicoes);
        }
        else
        {
            var obj=Contexto.LancarRefeicoes.Where(s => s.Id == _Id).FirstOrDefault();
            obj.DescricaoProduto = produtos.Where(s => s.Id == indprod).FirstOrDefault().Nome;
            obj.DescricaoRefeicao = tipoRefeicaos.Where(s => s.Id == indtiporefeicao).FirstOrDefault().DsTipoRefeicao;
            obj.QuantidadeLanc = Convert.ToDouble(QuantidadeLanc.Text);
            obj.Calorias = Convert.ToDouble(Calorias.Text);
            obj.datalanc = DateTime.Now.AddHours(-3);
            Contexto.Entry(obj).State=EntityState.Modified;
        }

        Contexto.SaveChanges();
        await DisplayAlert("Registro salvo", "Lançamento salvo com sucesso!", "OK");
        await Navigation.PushAsync(new AlimentacaoDiaria(), false);

    }

}