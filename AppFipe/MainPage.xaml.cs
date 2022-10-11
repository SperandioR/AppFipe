using Microsoft.Maui.Platform;
using System;

namespace AppFipe;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
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

	private void OnCalcular(object sender,EventArgs e)
	{
		int num1= Convert.ToInt32(Numero1.Text);
        int num2 = Convert.ToInt32(Numero2.Text);

		int soma = num1 + num2;
		resultado.Text = soma.ToString();
    }
}

