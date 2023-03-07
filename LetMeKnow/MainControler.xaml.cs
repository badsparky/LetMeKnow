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

    private void PutButton_Clicked(object sender, EventArgs e)
    {

    }
}

