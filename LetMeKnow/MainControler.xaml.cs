using LetMeKnow.TodoClass;
using LetMeKnow.Models;

namespace LetMeKnow;


public partial class MainControler : ContentPage
{
    public static ControlerModel Model;
    ToDoControler ToDos;


    public MainControler(ToDoControler ToDos, Shell shell)
    {
        this.ToDos = ToDos;
        DateTime startTime = DateTime.UtcNow;
        DateTime endTime = DateTime.Now;
        Model = new ControlerModel(ToDos, shell);
        BindingContext = Model;
        InitializeComponent();
        ToDos.ControlerEvent += RenderGraphics;
        Model.ToDoChnaged += ChnageTexts;
    }

    void RenderGraphics(object sender,EventArgs e){ if (GraphicsView.IsEnabled) GraphicsView.Invalidate(); }
    void ChnageTexts(ToDo toDo) { Goal.Text = toDo.Thing; }

}

