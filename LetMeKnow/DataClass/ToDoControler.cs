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
        public delegate void ToDoControlerEventHandler(object sender, EventArgs e);
        public event ToDoControlerEventHandler ControlerEvent;

        System.Timers.Timer Timer;
        List<ToDo> _ToDos { get; set; } = new List<ToDo>();
        ContentPage Page;
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

        public ToDoControler(AppShell shell) 
        {
            Timer = new System.Timers.Timer(100);
            Timer.Start();
            Timer.Elapsed += ExecuteDelegate;
            shell.Unloaded += (object sender, EventArgs e) => {Timer.Stop(); Timer.Dispose(); };
        }

        void ExecuteDelegate(object sender, EventArgs e) {if (ControlerEvent != null) { ControlerEvent(sender, e);} }

        public ToDo GetTodo(){ return ToDos.First(x => !x.isDone);}

        public void AddToDo(DateTime start, DateTime end, string todo)
        {
            _ToDos.Add(new ToDo(start, end, todo));
            _ToDos.Sort();
        }
    }
}