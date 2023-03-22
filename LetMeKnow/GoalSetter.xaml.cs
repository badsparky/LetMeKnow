using LetMeKnow.Models;
using LetMeKnow.TodoClass;

namespace LetMeKnow;


public partial class GoalSetter : ContentPage
{
	readonly SetterModel Model;
	ToDoControler ToDos;

	public GoalSetter(ToDoControler toDoControler)
	{
		Model = new SetterModel(toDoControler);
		BindingContext = Model;
		ToDos = toDoControler;
		InitializeComponent();
	}


    private async void PutButton_Clicked(object sender, EventArgs e)
    {
		if(! Model.AddTodo())
		{
			await DisplayAlert("Alart","Choose Collect Time","OK");
		}
    }

}

