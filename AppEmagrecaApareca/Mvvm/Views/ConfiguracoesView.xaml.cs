using AppEmagrecaApareca.Mvvm.Models;
using AppEmagrecaApareca.Mvvm.ViewModels;


namespace AppEmagrecaApareca;

public partial class ConfiguracoesView : ContentPage
{
	public ConfiguracoesView()
	{
		InitializeComponent();
		BindingContext = new ConfiguracoesViewModel();

    }

 //   private void OnClickCadastrar(object sender, EventArgs e)
	//{
	//	BancoContexto ContextoGeral = App._Contexto;
	//	if (ContextoGeral.Produtos.ToList().Count<50)
	//	{
	//		CarregaDadosGerais carrega = new CarregaDadosGerais();
	//		carrega.PopularGeral();
 //           DisplayAlert("Carregado", "Dados iniciais carregados com sucesso!", "OK");
 //       }
	//	else
	//	{
 //           DisplayAlert("Carregado", "Dados Carregados anteriormente!", "OK");
 //       }

	//	if (ContextoGeral.PerfilUsuarios.ToList().Count==0)
	//	{
 //           DisplayAlert("Perfil", "Para usar o sistema cadastre seu perfil!", "OK");
 //           Navigation.PushAsync(new PerfilUsuView());
 //       }

	//}
}