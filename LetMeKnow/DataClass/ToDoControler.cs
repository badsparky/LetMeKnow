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
        public delegate void ToDoControlerEventHandler(ToDo Todo);
        public event ToDoControlerEventHandler ControlerEvent;


        System.Timers.Timer Timer;
        List<ToDo> _ToDos = new List<ToDo>();
        ToDo ToDoNow { get; set; }

        public List<ToDo> ToDos {get{return _ToDos;}}

        public ToDoControler(AppShell shell) 
        {
            Timer = new System.Timers.Timer(200);
            Timer.Elapsed += ExecuteDelegate;
            shell.Loaded += (object sender, EventArgs e) => { Timer.Start(); };
            shell.Unloaded += (object sender, EventArgs e) => {Timer.Stop(); Timer.Dispose(); };
        }

        void ExecuteDelegate(object sender, EventArgs e) {ControlerEvent?.Invoke(ToDoNow); }

        public ToDo GetTodo(){ var todo= ToDos.FirstOrDefault(x => !x.isDone)?? new ToDo(DateTime.Now, DateTime.Now, "Nothing For Now");ToDoNow=todo; return todo; }

        public void AddToDo(ToDo toDo)
        {
            _ToDos.Add(toDo);
            _ToDos.Sort();
        }
    }
}