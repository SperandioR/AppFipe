using AppFipe.Repositorios; //Chamada automática da pasta repositórios.
using Microsoft.Maui.Platform;
using System;
using System.Security.Cryptography.X509Certificates;

namespace AppFipe;

public partial class MainPage : ContentPage
{
    //picker tipo tem que carregar o picker o pickerFabricantes.

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



    }


}

