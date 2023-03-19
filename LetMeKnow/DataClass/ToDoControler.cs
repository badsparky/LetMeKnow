using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Timers;

namespace LetMeKnow.TodoClass
{
    public class ToDoControler
    {
        List<ToDo> _ToDos { get; set; } = new List<ToDo>();
        System.Timers.Timer _Timer;
        public delegate 
        public List<ToDo> ToDos
        {
            get
            {
                if(_ToDos.Count == 0)
                    return new List<ToDo> { new ToDo(DateTime.Now,DateTime.Now.AddMinutes(10),"Nothing")};
                else
                    return _ToDos;
            }
        }

        public ToDoControler(ContentPage pahe) 
        {
            _Timer = new System.Timers.Timer(100);
            Handler = _Timer.Interval;
            
        }
        public ToDo GetTodo(){ return ToDos.First(x => !x.isDone);}

        public void AddToDo(DateTime start, DateTime end, string todo)
        {
            _ToDos.Add(new ToDo(start, end, todo));
            _ToDos.Sort();
        }
        public class Watcher
        {
            public event WatchHandler WatchEvent;
            public delegate void WatchHandler(object sender, EventArgs e);
        }
    }


}
