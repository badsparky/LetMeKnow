using LetMeKnow.Models;

namespace LetMeKnow;


public partial class GoalSetter : ContentPage
{
	int count = 0;

	public GoalSetter()
	{
		BindingContext = new MainModel();
		InitializeComponent();
	}


    private void PutButton_Clicked(object sender, EventArgs e)
    {

    }

}

