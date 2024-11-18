using AppEmagrecaApareca.Mvvm.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Mvvm.ViewModels
{
    public partial class EditarVisualizarProdutoViewModel: ObservableObject
    {
        [ObservableProperty]
        private int _id;
        [ObservableProperty]
        private string _nome;
        [ObservableProperty]
        private double _quantidade;
        [ObservableProperty]
        private string _unidade;
        [ObservableProperty]
        private double _calorias;


        public EditarVisualizarProdutoViewModel()
        {

        }

        public EditarVisualizarProdutoViewModel(Produto produto)
        {
            Id = produto.Id;
            Nome = produto.Nome;
            Quantidade = produto.Quantidade;
            Unidade = produto.Unidade;
            Calorias = produto.Calorias;
        }

        [RelayCommand]
        private void CadastrarAtualizar()
        {
            var Contexto = App._Contexto;
            if (Id == 0)
            {
                Produto produto = new Produto();
                produto.Nome = Nome;
                produto.Quantidade = Quantidade;
                produto.Unidade = Unidade;
                produto.Calorias = Calorias;
                Contexto.Add(produto);

            }
            else
            {
                var obj = Contexto.Produtos.Where(s => s.Id == Id).FirstOrDefault();
                obj.Id = Id;
                obj.Nome = Nome;
                obj.Quantidade =Quantidade;
                obj.Unidade = Unidade;
                obj.Calorias = Calorias;
                Contexto.Entry(obj).State = EntityState.Modified;

            }

            Contexto.SaveChanges();
            App.Current.MainPage.DisplayAlert("Registro salvo", "Lançamento salvo com sucesso!", "OK");
            var stack = Shell.Current.Navigation.NavigationStack.ToArray();
            for (int i = stack.Length - 1; i > 0; i--)
            {
                Shell.Current.Navigation.RemovePage(stack[i]);
            }
            Shell.Current.GoToAsync("//TelaInicio");
        }

    }
}
