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

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";
		
		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void MainButton_Clicked(object sender, EventArgs e)
    {

    }
    private void MinorButton_Clicked(object sender, EventArgs e)
    {

    }
}

