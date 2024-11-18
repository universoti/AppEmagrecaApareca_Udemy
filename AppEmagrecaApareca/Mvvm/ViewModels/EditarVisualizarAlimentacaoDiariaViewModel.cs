﻿using AppEmagrecaApareca.Mvvm.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmagrecaApareca.Mvvm.ViewModels
{
    public partial class EditarVisualizarAlimentacaoDiariaViewModel: ObservableObject
    {
        [ObservableProperty]
        private int _id;
        
        [ObservableProperty]
        private int _id_indice = -1;

        [ObservableProperty]
        private int _id_indice_tiporefeicao = -1;

        [ObservableProperty]
        private int _iproduto;
        [ObservableProperty]
        private string _descricaoProduto;
        [ObservableProperty]
        private int _idTipoRefeicao;
        [ObservableProperty]
        public string _descricaoRefeicao;
        [ObservableProperty]
        private double _quantidadeLanc;
        [ObservableProperty]
        public double _calorias;
        [ObservableProperty]
        private DateTime _datalanc;





        public List<SelectItemProdutoModel> produtos { get; set; }
        public List<SelectItemTipoRefeicao> tipoRefeicaos { get; set; }

        public EditarVisualizarAlimentacaoDiariaViewModel()
        {
            CarregaPickers();
        }

        public EditarVisualizarAlimentacaoDiariaViewModel(LancarRefeicoes lancarRefeicoes)
        {
            CarregaPickers();
            Id= lancarRefeicoes.Id;
            QuantidadeLanc = lancarRefeicoes.QuantidadeLanc;
            Iproduto = lancarRefeicoes.Iproduto;
            IdTipoRefeicao = lancarRefeicoes.IdTipoRefeicao;
            DescricaoProduto = lancarRefeicoes.DescricaoProduto;
            DescricaoRefeicao = lancarRefeicoes.DescricaoRefeicao;
            Datalanc = lancarRefeicoes.datalanc;
            Calorias = lancarRefeicoes.Calorias;
            IdTipoRefeicao=produtos.Where(s=>s.Id==Iproduto).FirstOrDefault().Indice;
            Id_indice_tiporefeicao=tipoRefeicaos.Where(s=>s.Id==IdTipoRefeicao).FirstOrDefault().Indice; 

        }

        public void CarregaPickers()
        {
            popularSelectTipoRefeicao();
            populaSelectProduto();
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



        private void CadastrarAtualizar()
        {
            var Contexto = App._Contexto;

            if (Id == 0)
            {
                LancarRefeicoes refeicoes = new LancarRefeicoes();
                refeicoes.Id = Id;
                refeicoes.QuantidadeLanc = QuantidadeLanc;
                refeicoes.DescricaoProduto = produtos.Where(s => s.Id == Iproduto).FirstOrDefault().Nome;
                refeicoes.DescricaoRefeicao = tipoRefeicaos.Where(s => s.Id == IdTipoRefeicao).FirstOrDefault().DsTipoRefeicao;
                refeicoes.Iproduto = Iproduto;
                refeicoes.IdTipoRefeicao = IdTipoRefeicao;
                refeicoes.datalanc = DateTime.Now;
                refeicoes.Calorias = Calorias;
                Contexto.Add(refeicoes);
            }
            else
            {
                var obj = Contexto.LancarRefeicoes.Where(s => s.Id == Id).FirstOrDefault();
                obj.Id = Id;
                obj.DescricaoProduto = produtos.Where(s => s.Id == Iproduto).FirstOrDefault().Nome;
                obj.DescricaoRefeicao = tipoRefeicaos.Where(s => s.Id == IdTipoRefeicao).FirstOrDefault().DsTipoRefeicao;
                obj.QuantidadeLanc = QuantidadeLanc;
                obj.Calorias = Calorias;
                obj.datalanc = DateTime.Now;
                Contexto.Entry(obj).State = EntityState.Modified;
            }

            Contexto.SaveChanges();
            Shell.Current.DisplayAlert("Registro salvo", "Lançamento salvo com sucesso!", "OK");
            ///await Navigation.PushAsync(new AlimentacaoDiariaView(), false);

        }

    }
}
