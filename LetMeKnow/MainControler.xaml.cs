using LetMeKnow.TodoClass;
using LetMeKnow.Models;

namespace LetMeKnow;


public partial class MainControler : ContentPage
{
    public static ControlerModel Model;

    public delegate void WatcherEventHandler(ToDo toDo);
    public event WatcherEventHandler WatcherEvent;

    public MainControler(ToDoControler ToDos, Shell shell)
    {
        DateTime startTime = DateTime.UtcNow;
        DateTime endTime = DateTime.Now;
        Model = new ControlerModel(ToDos, shell);
        BindingContext = Model;
        InitializeComponent();
        ToDos.ControlerEvent += RenderGraphics;
    }

    void RenderGraphics(ToDo Todo) { if (GraphicsView.IsEnabled) GraphicsView.Invalidate(); }

    private void  TextChange_Clicked(object sender, EventArgs e)
    {
        (LeftTime.IsVisible, Goal.IsVisible) = (Goal.IsVisible, LeftTime.IsVisible);
    }
}

