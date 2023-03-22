using LetMeKnow.TodoClass;
using LetMeKnow.Graphics;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

namespace LetMeKnow.Models
{
    public class ControlerModel:Base
    {
        public string StartTime { get=> ToDo.Start.ToString("HH:mm");  }
        public string EndTime { get =>ToDo.End.ToString("HH:mm");  }
        public string GoalString { get => ToDo.Thing; }
        public GraphicsDrawable GraphicsDrawable { get; private set; }
        public double Span { get => ToDo.Span;  }
        public double LeftTime { get => ToDo.LeftTime; }
        public double Height { get => 500; }
        public double Width { get => 500; }

        public delegate void ToDoChnagedHandler(ToDo todo);
        public event ToDoChnagedHandler ToDoChnaged;

        ToDoControler ToDos;
        Shell Shell;
        ToDo ToDo;

        public ControlerModel(ToDoControler toDoControler,Shell shell) 
        { 
            ToDos = toDoControler;
            ToDo= ToDos.GetTodo();
            GraphicsDrawable=new GraphicsDrawable(toDoControler);
            GraphicsDrawable.ToDoChnaged += SetToDo;
            this.Shell = shell;
        }

        void SetToDo(ToDo toDo){ToDo=toDo; ToDoChnaged?.Invoke(this.ToDo); }

        public double GetProgress()
        {
            return  Math.Min(1,LeftTime/Span);
        }
    }


}
