using AppEmagrecaApareca.Mvvm.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Mvvm.ViewModels
{
    public partial class ProdutosViewModel:ObservableObject
    {
        public List<Produto> ListarProdutos { get; set; }

        public ProdutosViewModel()
        {
            ListarProdutos = App._Contexto.Produtos.ToList();
        }

        [ObservableProperty]
        private bool _isRefreshing;

        [RelayCommand]
        public void AtualizarTela()
        {
            IsRefreshing = false;
        }
    }
}
