using AppEmagrecaApareca.Mvvm.Models;
using Microsoft.Maui.Controls;
namespace AppEmagrecaApareca
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private readonly BancoContexto _dbcontext;
        public MainPage(BancoContexto dbcontext)
        {
            _dbcontext = dbcontext; 
            InitializeComponent();

            //Carro carros = new Carro();            
            //carros.Nome = "Gol";
            //carros.Ano = "2012";
            //_dbcontext.Carros.Add(carros);

            //_dbcontext.Carros.Add(new Carro() { Nome = "Ecosport", Ano = "2015" });
            //_dbcontext.SaveChanges();
            
            lcarros.ItemsSource = _dbcontext.Carros;    


        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

        }
    }

}
