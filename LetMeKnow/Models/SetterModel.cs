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
        public TimeSpan Start { get; set; }=DateTime.Now.TimeOfDay;
        public TimeSpan End { get; set; } = DateTime.Now.TimeOfDay;
        public ObservableCollection<ToDo.Viewing> Goals { get; set; }

        public SetterModel(ToDoControler toDoControler)
        {
            ToDos = toDoControler;
            Goals=new ObservableCollection<ToDo.Viewing>(ToDos.ToDos.Select(x=>new ToDo.Viewing(x)));
        }

        public bool AddTodo()
        {
            try
            {
                var startDate=DateTime.Today.Add(Start);
                var endDate=DateTime.Today.Add(End);
                if(startDate>endDate) endDate= endDate.AddDays(1);
                var todo = new ToDo(startDate,endDate, NewGoal);
                ToDos.AddToDo(todo);
                Goals.Add(new ToDo.Viewing(todo));
                return true;
            }
            catch { return false;}
        }
    }
}
