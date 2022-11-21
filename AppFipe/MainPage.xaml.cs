using AppFipe.Models;
using AppFipe.Repositorios; //Chamada automática da pasta repositórios.
using Javax.Security.Auth;
using Microsoft.Maui.Platform;
using System;
using System.Security.Cryptography.X509Certificates;

namespace AppFipe;

public partial class MainPage : ContentPage
{
    //picker tipo tem que carregar o picker o pickerFabricantes.

    private static string sTipoVeiculo;

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
    void SelTipo(object sender, EventArgs e) //evento para carregar o arquivo: MainPage.xamI
    {
        var pickerTipo = (Picker)sender; //Atributo:pickerTipo.
        int selectedIndex = pickerTipo.SelectedIndex; //propiedades:SelectedIndex.

        if (selectedIndex != -1)
        {
            Veiculos Veiculos = (Veiculos)pickerTipo.ItemsSource[selectedIndex];
            sTipoVeiculo = Veiculos.Tipo;

            CarregarFabricantes(Veiculos.Tipo);

        }
    }

    private void CarregarFabricantes(String TipoVeiculo)
    {
        pickerFabricante.Title = "Selecione um fabricante";
        pickerFabricante.ItemsSource = FabricanteRepositorios.ListarFabricantes(TipoVeiculo);
        pickerFabricante.ItemDisplayBinding = new Binding("nome");


    }

}




