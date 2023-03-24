using LetMeKnow.TodoClass;
using LetMeKnow.Models;

namespace LetMeKnow;


public partial class MainControler : ContentPage
{
    public static ControlerModel Model;
    ToDoControler ToDos;

    System.Timers.Timer WatchTimer;

    public delegate void WatcherEventHandler(ToDo toDo);
    public event WatcherEventHandler WatcherEvent;

    public MainControler(ToDoControler ToDos, Shell shell)
    {
        this.ToDos = ToDos;
        DateTime startTime = DateTime.UtcNow;
        DateTime endTime = DateTime.Now;
        Model = new ControlerModel(ToDos, shell);
        BindingContext = Model;
        InitializeComponent();
        ToDos.ControlerEvent += RenderGraphics;
        ToDos.ControlerEvent += ChangeTexts;
        Model.ToDoChnaged += ChangeTexts;
        //WatchTimer = new System.Timers.Timer(1000);
        //WatchTimer.Elapsed += (sender,e) => { invoke };
        //WatchTimer.Start();
        //shell.Unloaded += (sender, e) => { WatchTimer.Stop(); WatchTimer.Dispose(); };
    }

    void RenderGraphics(ToDo Todo) { if (GraphicsView.IsEnabled) GraphicsView.Invalidate(); }
    void ChangeTexts(ToDo toDo) { Goal.Text = DateTime.Now.ToString(); ; /*LeftTime.Text = toDo.LeftMinuetsAndHours;*/ }

    private void  TextChange_Clicked(object sender, EventArgs e)
    {
        (LeftTime.IsVisible, Goal.IsVisible) = (Goal.IsVisible, LeftTime.IsVisible);
    }
}

