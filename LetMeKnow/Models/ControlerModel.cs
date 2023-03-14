using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetMeKnow.DataClass;

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
        ToDo ToDo;

        public ControlerModel(ToDo toDo) 
        { 
            SetToDo(toDo);
        }


        public void SetToDo(ToDo toDo)
        {
            ToDo=toDo;
            GraphicsDrawable= new GraphicsDrawable(toDo);
            //OnPropertyChanged(nameof(GraphicsDrawable));
        }

        public double GetProgress()
        {
            return  Math.Min(1,LeftTime/Span);
        }
    }

    public class GraphicsDrawable : IDrawable
    {
        ToDo ToDo;
        double Procedure { get { return Math.Min(1, ToDo.LeftTime / ToDo.Span); } }

        public GraphicsDrawable(ToDo todo)
        {
            ToDo= todo;
        }

        public void Draw(ICanvas canvas, RectF rect)
        {
            canvas.FillColor = Colors.Yellow;
            canvas.DrawRectangle(100, 100, 100, 100);
        }
    }
}
