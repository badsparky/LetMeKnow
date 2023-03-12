using LetMeKnow.Models;

namespace LetMeKnow;


public partial class GoalSetter : ContentPage
{
	int count = 0;
	readonly SetterModel Model;


	public GoalSetter()
	{
		Model = new SetterModel();
		BindingContext = Model;
		InitializeComponent();
	}


    private void PutButton_Clicked(object sender, EventArgs e)
    {
    }

}

