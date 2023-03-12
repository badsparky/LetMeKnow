using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetMeKnow.DataClass
{
    public class ToDo :IComparable<ToDo>
    {
        public DateTime Start;
        public DateTime End;
        public string Thing;
        public double Span { get { return Math.Sqrt(Start.Subtract(End).TotalMilliseconds); } }
        public double LeftTime { get { return Math.Max((End - DateTime.Now).Microseconds, 0); } }
        public ToDo(DateTime start, DateTime end, string todo) { this.Start = start; this.End = end; this.Thing = todo; }
        public bool isDone { get { return (End - DateTime.Now).Milliseconds > 0; } }

        int IComparable<ToDo>.CompareTo(ToDo todo)
        {
            return Math.Sign((this.Start - todo.Start).Microseconds);
        }
    }
}
