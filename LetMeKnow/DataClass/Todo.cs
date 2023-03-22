using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetMeKnow.TodoClass
{
    public class ToDo :IComparable<ToDo>
    {
        public DateTime Start ;
        public DateTime End;
        public string Thing;
        public double Span { 
            get
            {
                var tmp = (Start.Subtract(End));
                var tmp2 = tmp.TotalMilliseconds;
                return Math.Abs((Start.Subtract(End)).TotalMilliseconds);
            }
        }
        public double LeftTime { get { return Math.Max((End - DateTime.Now).TotalMilliseconds, 0); } }
        public ToDo(DateTime start, DateTime end, string todo) 
        {
            if(end.Subtract(start).TotalMilliseconds< 0) {  }
            this.Start = start; this.End = end; this.Thing = todo; 
        }
        public bool isDone { get { return (End - DateTime.Now).Milliseconds < 0; } }

        int IComparable<ToDo>.CompareTo(ToDo todo)
        {
            return Math.Sign((this.Start - todo.Start).Microseconds);
        }

        public class Viewing
        {
            ToDo ToDo;
            public string Start2End { get { return $"{ToDo.Start.ToString("HH:mm")} - {ToDo.End.ToString($"HH:mm")}\t({(ToDo.End-ToDo.Start).TotalMilliseconds})\t"; } }
            public string Goal { get { return "\t"+ToDo.Thing; } }
            public Viewing(ToDo toDo) { this.ToDo = toDo; }
        }
        
    }
}
