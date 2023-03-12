using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LetMeKnow.DataClass
{
    public class ToDoControler
    {
        List<ToDo> _ToDos { get; set; }
        public List<ToDo> ToDos
        {
            get
            {
                if(_ToDos.Count == 0)
                    return new List<ToDo> { new ToDo(DateTime.Now,DateTime.Now.AddHours(2),"Nothing")};
                else
                    return _ToDos;
            }
        }

        public ToDoControler() { }
        public ToDo GetTodo(){ return ToDos.First(x => !x.isDone);}

        public void AddToDo(DateTime start, DateTime end, string todo)
        {
            ToDos.Add(new ToDo(start, end, todo));
            ToDos.Sort();
        }
    }
}
