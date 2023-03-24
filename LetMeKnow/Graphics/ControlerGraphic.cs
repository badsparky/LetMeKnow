using LetMeKnow.TodoClass;
using LetMeKnow.Models;
using LetMeKnow.Graphics.Drawer;

namespace LetMeKnow.Graphics
{
    public class GraphicsDrawable : IDrawable
    {
        ControlerModel ControlerModel;
        ToDoControler ToDos;
        ToDo ToDo;
        double Procedure { get { return Math.Min(1, ToDo.LeftTimeMillisecond / ToDo.Span); } }
        public delegate void ToDoExpireHAndler(ToDo todo);
        public event ToDoExpireHAndler ToDoExpired; 
        public delegate void ToDoChangedHAndler(ToDo todo);
        public event ToDoExpireHAndler ToDoChnaged;

        public GraphicsDrawable(ToDoControler todos)
        {
            ToDos = todos;
            ToDo = todos.GetTodo();
        }

        void ChangeToDo() { ToDo = ToDos.GetTodo();}

        public void Draw(ICanvas canvas, RectF rect)
        {
            if(Procedure == 0) { ToDoExpired?.Invoke(ToDo);ChangeToDo();ToDoChnaged?.Invoke(ToDo); }
            var shape = new Drawer.Drawer.Ellipse(Math.Min(rect.Width, rect.Height) / 2);
            Drawer.Drawer.Draw(canvas, rect, shape, Colors.LightYellow);
            Drawer.Drawer.Draw(canvas, rect,shape,Colors.Yellow, Procedure);
        }
       
    }
}
