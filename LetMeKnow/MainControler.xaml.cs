using LetMeKnow.DataClass;
using LetMeKnow.Models;
using Microsoft.Maui.Graphics;

namespace LetMeKnow;


public partial class MainControler : ContentPage
{
	public static ControlerModel Model;
	ToDoControler ToDos;

	public MainControler(ToDoControler ToDos)
	{
		this.ToDos = ToDos;
		DateTime startTime= DateTime.UtcNow;
		DateTime endTime= DateTime.Now;
		Model = new ControlerModel(ToDos.GetTodo());
		BindingContext = Model;
		InitializeComponent();
	}
}


