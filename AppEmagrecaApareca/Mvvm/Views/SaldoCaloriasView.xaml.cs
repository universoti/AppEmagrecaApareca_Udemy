namespace AppEmagrecaApareca;

public partial class SaldoCaloriasView : ContentPage
{
	public SaldoCaloriasView()
	{
		InitializeComponent();
		CarregarSaldos();	
	}

	private void CarregarSaldos()
	{
		var ContextoDiaro = App._Contexto;
		lcaloriasConsumidas.Text = ContextoDiaro.LancarRefeicoes.
									Where(s => s.datalanc >= DateTime.Now.AddHours(-3).Date).Sum(s=>s.Calorias).ToString();
        lcaloriasRecomendada.Text = ContextoDiaro.PerfilUsuarios.FirstOrDefault().RecomendacaoCalorica.ToString();
		var saldo = ContextoDiaro.PerfilUsuarios.FirstOrDefault().RecomendacaoCalorica
									 -
									(decimal)ContextoDiaro.LancarRefeicoes.
									Where(s => s.datalanc >= DateTime.Now.AddHours(-3).Date).Sum(s => s.Calorias);

		lSaldo.Text = saldo.ToString();

		var porcetegem = Convert.ToDouble(lcaloriasConsumidas.Text) / Convert.ToDouble(lcaloriasRecomendada.Text);
		decimal _nporcet =Math.Round((decimal)(porcetegem * 100),2) ;
		nporcet.Text = _nporcet.ToString() + "(%)";
		Porcetagem.Progress = porcetegem;

		if (_nporcet<=70)
		{
			Porcetagem.ProgressColor = Colors.GreenYellow;
		}
		else
        if (_nporcet <= 90)
        {
            Porcetagem.ProgressColor = Colors.Orange;
        }
		else
		{
            Porcetagem.ProgressColor = Colors.Red;
        }

    }


	private async void Fechar(object sender,EventArgs e)
	{
        await Navigation.PushAsync(new AlimentacaoDiariaView(), false);
    }
}