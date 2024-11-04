namespace AppEmagrecaApareca
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TelaInicioView),typeof(TelaInicioView));
        }
    }
}
