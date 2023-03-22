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
        List<ToDo> _ToDos { get; set; } = new List<ToDo>();
        ContentPage Page;
        public ObservableCollection<ToDo> ToDos
        {
            get
            {
                if(_ToDos.Count == 0)
                    return new ObservableCollection<ToDo> { new ToDo(DateTime.Now,DateTime.Now.AddMinutes(10),"Nothing")};
                else
                    return new ObservableCollection<ToDo>(Sort());
            }
        }

        public ToDoControler(AppShell shell) 
        {
            Timer = new System.Timers.Timer(200);
            Timer.Elapsed += ExecuteDelegate;
            shell.Loaded += (object sender, EventArgs e) => { Timer.Start(); };
            shell.Unloaded += (object sender, EventArgs e) => {Timer.Stop(); Timer.Dispose(); };
        }

        void ExecuteDelegate(object sender, EventArgs e) {if (ControlerEvent != null) { ControlerEvent(sender, e);} }

        public ToDo GetTodo(){ return ToDos.First(x => !x.isDone);}

        public void AddToDo(ToDo toDo)
        {
            _ToDos.Add(toDo);
            _ToDos.Sort();
        }
        IEnumerable<ToDo> Sort()
        {
            _ToDos.Sort();
            return _ToDos.ToImmutableList();
        }
    }
}