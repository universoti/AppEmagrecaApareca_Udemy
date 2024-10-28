using AppEmagrecaApareca.Mvvm.Models;

namespace AppEmagrecaApareca
{
    public partial class App : Application
    {
        public static BancoContexto _Contexto;
        public App(BancoContexto bancoContexto)
        {
            _Contexto = bancoContexto;  
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
