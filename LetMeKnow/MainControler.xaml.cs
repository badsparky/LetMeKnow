using LetMeKnow.DataClass;
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
        Model = new ControlerModel(ToDos.GetTodo(), shell);
        BindingContext = Model;
        InitializeComponent();
        
        Loaded+= (s, e) =>
        {
            while (true)
            {
                GraphicsView.Invalidate();
            }
        };
    }
}

