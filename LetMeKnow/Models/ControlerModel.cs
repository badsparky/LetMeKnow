﻿using LetMeKnow.TodoClass;
using LetMeKnow.Graphics;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

namespace LetMeKnow.Models
{
    public class ControlerModel:Base
    {
        public string GoalString { get => ToDo.Thing; }
        public GraphicsDrawable GraphicsDrawable { get; private set; }
        public double Height { get => 500; }
        public double Width { get => 500; }
        public  string LeftMinuetsAndHours { get => ToDo.LeftMinuetsAndHours; }
        public ToDo CurrentToDo { get => ToDo; }
        double LeftTime { get => ToDo.LeftTimeMillisecond; }
        double Span { get => ToDo.Span;  }
        

        public delegate void ToDoChnagedHandler(ToDo todo);
        public event ToDoChnagedHandler ToDoChnaged;


        ToDoControler ToDos;
        Shell Shell;
        ToDo ToDo;

        public ControlerModel(ToDoControler toDoControler,Shell shell) 
        { 
            ToDos = toDoControler;
            ToDo= ToDos.GetTodo();
            GraphicsDrawable=new GraphicsDrawable(toDoControler);
            GraphicsDrawable.ToDoChnaged += SetToDo;
            this.Shell = shell;
        }

        void SetToDo(ToDo toDo){ToDo=toDo; ToDoChnaged?.Invoke(this.ToDo); }



        public double GetProgress()
        {
            return  Math.Min(1,LeftTime/Span);
        }
    }


}
