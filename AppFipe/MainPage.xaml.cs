using AppFipe.Repositorios;
using Microsoft.Maui.Platform;
using System;

namespace AppFipe;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		CarregarTipos();
	}

	//Criando método para carregar os Tipos de veiculo.
	public void CarregarTipos()
	{
		pickerTipo.Title = "Selecione um tipo de veiculo";
		pickerTipo.ItemsSource = VeiculoRepositorios.ListarVeiculos();
		pickerTipo.ItemDisplayBinding = new Binding("Tipo");

	}
    //criando evento delegates.
    void SelTipo(object sender,EventArgs e) 
	{


	}

	
}

