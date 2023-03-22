using LetMeKnow.TodoClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetMeKnow.Models
{
    public class SetterModel:Base
    {
        ToDoControler ToDos;
        public string NewGoal { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ObservableCollection<string> Goals { get; set; }

        public SetterModel(ToDoControler toDoControler)
        {
            ToDos = toDoControler;
        }

        public bool AddTodo()
        {
            try
            {
                ToDos.AddToDo(StartTime, EndTime,NewGoal);
                Goals.Add(NewGoal);
                return true;
            }
            catch { return false;}
        }
    }
}
