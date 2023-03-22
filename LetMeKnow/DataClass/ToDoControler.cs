using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Timers;
using System.Collections.ObjectModel;
using System.Collections.Immutable;

namespace LetMeKnow.TodoClass
{
    public class ToDoControler
    {
        public delegate void ToDoControlerEventHandler(object sender, EventArgs e);
        public event ToDoControlerEventHandler ControlerEvent;


        System.Timers.Timer Timer;
        List<ToDo> _ToDos = new List<ToDo>();

        public List<ToDo> ToDos {get{return _ToDos;}}

        public ToDoControler(AppShell shell) 
        {
            Timer = new System.Timers.Timer(200);
            Timer.Elapsed += ExecuteDelegate;
            shell.Loaded += (object sender, EventArgs e) => { Timer.Start(); };
            shell.Unloaded += (object sender, EventArgs e) => {Timer.Stop(); Timer.Dispose(); };
        }

        void ExecuteDelegate(object sender, EventArgs e) {if (ControlerEvent != null) { ControlerEvent(sender, e);} }

        public ToDo GetTodo(){ return ToDos.FirstOrDefault(x => !x.isDone)?? new ToDo(DateTime.Now, DateTime.Now.AddSeconds(2), "Nothing For Now"); }

        public void AddToDo(ToDo toDo)
        {
            _ToDos.Add(toDo);
            _ToDos.Sort();
        }
    }
}