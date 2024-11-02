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
		

    }

	void SelSexo(object sender, EventArgs e)
	{
		var pickerSexo = (Picker)sender;
		int selectIndex=pickerSexo.SelectedIndex;

		if (selectIndex != -1)
		{
			SexoModel sexo=(SexoModel)pickerSexo.ItemsSource[selectIndex];
			_Idsexo = sexo.Id;
			
			eds_sexo.Text = sexo.DsSexo;


        }

    }

	
	  
	
		

}