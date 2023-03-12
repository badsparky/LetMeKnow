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
        public string RecetGoal { get; set; } = "Test";
        public string StartTime { get { return ToDo.Start.ToString("HH:mm"); } }
        public string EndTime { get { return ToDo.End.ToString("HH:mm"); } }
        public string GoalString { get { return ToDo.Thing; } }
        public GraphicsDrawable GraphicsDrawable { get; private set; }
        double Span { get {  return ToDo.Span; } }
        ToDo ToDo;

        public ControlerModel(ToDo toDo) 
        { 
            ToDo = toDo;
            SetToDo(toDo);
        }


        public void SetToDo(ToDo toDo)
        {
            ToDo=toDo;
        }

        public double GetProgress()
        {
            return Span;
        }
    }

    public class TinyGoal
    {
        public string CompletedThing { get; set; }
        public string Time { get { return DateTime.ToString("HH:mm"); } }
        readonly DateTime DateTime;
        public TinyGoal(string Thing)
        {
            this.DateTime = DateTime.Now;
            CompletedThing = Thing;
        }
    }

}
