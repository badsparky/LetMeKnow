using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetMeKnow.Models
{
    public class MainModel:Base
    {
        public string Text_Main { get; set; } = "Test";
        public string Text_Minor { get; set; } = "Test";
        public string TinyGoal { get; set; }= "Test";
        public bool IsActive_Minor { get; set; } = false;


    }
}
