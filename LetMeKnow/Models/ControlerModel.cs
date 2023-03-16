using LetMeKnow.DataClass;
using LetMeKnow.Graphics;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

namespace LetMeKnow.Models
{
    public class ControlerModel:Base
    {
        public string StartTime { get { return ToDo.Start.ToString("HH:mm"); } }
        public string EndTime { get { return ToDo.End.ToString("HH:mm"); } }
        public string GoalString { get { return ToDo.Thing; } }
        public GraphicsDrawable GraphicsDrawable { get; private set; }
        public double Span { get {  return ToDo.Span; } }
        public double LeftTime { get { return ToDo.LeftTime; } }
        public double Height { get { return 500; } }
        public double Width { get { return 500; } }
        Shell Shell;
        ToDo ToDo;

        public ControlerModel(ToDo toDo,Shell shell) 
        { 
            SetToDo(toDo);
            this.Shell = shell;
        }


        public void SetToDo(ToDo toDo)
        {
            ToDo=toDo;
            GraphicsDrawable= new GraphicsDrawable(toDo);
        }

        public double GetProgress()
        {
            return  Math.Min(1,LeftTime/Span);
        }
    }


}
