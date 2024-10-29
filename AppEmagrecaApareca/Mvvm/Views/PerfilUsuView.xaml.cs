using AppEmagrecaApareca.Mvvm.Models;
using AppEmagrecaApareca.Mvvm.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography;

namespace AppEmagrecaApareca;

public partial class PerfilUsuView : ContentPage
{
	private int _Idsexo;
	private string STipoSexo;
	private int _id;
	public PerfilUsuView()
	{
		InitializeComponent();
		BindingContext = new PerfilUsuViewModel();
		CarregarTipos();
		var Contexto = App._Contexto;
        try
		{
            _id = Contexto.PerfilUsuarios.Where(s => s.Id > 0).FirstOrDefault().Id;
        }
		catch (Exception)
		{

			//throw;
		}

        if (_id > 0)
        {
            var obj = Contexto.PerfilUsuarios.Where(s => s.Id == _id).FirstOrDefault();
            Altura.Text= obj.Altura.ToString();
            Idade.Text=obj.Idade.ToString();
            Peso.Text = obj.Peso.ToString();
            RecomendacaoCalorica.Text = obj.RecomendacaoCalorica.ToString();
            RecomendacaoPeso.Text = obj.RecomendacaoPeso.ToString();
			pickerSexo.SelectedIndex = obj.IdSexo;
            Nome.Text = obj.Nome.ToString();
            Idade.Text = obj.Idade.ToString();

        }

    }

	public void CarregarTipos()
	{
		pickerSexo.Title = "Selecione sexo";		
		pickerSexo.ItemsSource = new SexoModel().lSexo();
		pickerSexo.ItemDisplayBinding=new Binding("DsSexo");
	}

	void SelSexo(object sender, EventArgs e)
	{
		var pickerSexo = (Picker)sender;
		int selectIndex=pickerSexo.SelectedIndex;

		if (selectIndex != -1)
		{
			SexoModel sexo=(SexoModel)pickerSexo.ItemsSource[selectIndex];
			_Idsexo = sexo.Id;
			STipoSexo = sexo.DsSexo;
		
		}

    }

	private async void OnAlterar(object sender,EventArgs e)
	{
		int _id = 0;
		var Contexto=App._Contexto;

		try
		{
            _id = Contexto.PerfilUsuarios.Where(s => s.Id > 0).FirstOrDefault().Id;
        }
		catch (Exception)
		{

			
		}

		if (_id!=0)
		{
			var obj=Contexto.PerfilUsuarios.Where(s=>s.Id==_id).FirstOrDefault();	
			obj.Altura=Convert.ToDecimal(Altura.Text);
            obj.Idade = Convert.ToInt32(Idade.Text);
			obj.Nome= Nome.Text;
			obj.Sexo = STipoSexo;
			obj.IdSexo = _Idsexo;
            obj.RecomendacaoCalorica = Convert.ToDecimal(RecomendacaoCalorica.Text);
            obj.RecomendacaoPeso = Convert.ToDecimal(RecomendacaoPeso.Text);

			Contexto.Entry(obj).State=EntityState.Modified;

        }
		else
		{
			PerfilUsuario perfil = new PerfilUsuario()
			{
				Altura= Convert.ToDecimal(Altura.Text),
                Idade = Convert.ToInt32(Idade.Text),
                Nome = Nome.Text,
                Peso = Convert.ToDecimal(Peso.Text),
                RecomendacaoCalorica = Convert.ToDecimal(RecomendacaoCalorica.Text),
                RecomendacaoPeso = Convert.ToDecimal(RecomendacaoPeso.Text),
				IdSexo=_Idsexo,
				Sexo=STipoSexo

            };
			Contexto.PerfilUsuarios.Add(perfil);
		}

		Contexto.SaveChanges();

        DisplayAlert("Registro salvo", "Perfil salvo com sucesso!", "ok");
    }

	  
	
		

}