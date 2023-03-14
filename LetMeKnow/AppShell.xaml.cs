using LetMeKnow.DataClass;

namespace LetMeKnow;

public partial class AppShell : Shell
{
	public  GoalSetter GoalSetter { set; get; }
	public  MainControler MainControler { set; get; }

	public ToDoControler Todos; 

    public AppShell()
	{
		Todos = new ToDoControler();
		GoalSetter = new GoalSetter();
		MainControler = new MainControler(Todos);
		BindingContext = this;
		InitializeComponent();
	}
}
