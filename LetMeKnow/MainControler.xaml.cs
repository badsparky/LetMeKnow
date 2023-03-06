using LetMeKnow.Models;

namespace LetMeKnow;


public partial class MainControler : ContentPage
{
	int count = 0;

	public MainControler()
	{
		BindingContext = new MainModel();
		InitializeComponent();
	}


    private void MainButton_Clicked(object sender, EventArgs e)
    {

    }
    private void MinorButton_Clicked(object sender, EventArgs e)
    {

    }

    private void PutButton_Clicked(object sender, EventArgs e)
    {

    }
}

