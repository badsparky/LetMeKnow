using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetMeKnow.MyExceptio;

public class InvalidTimeException : Exception
{
    public InvalidTimeException() { }
    public InvalidTimeException(string Name):base($"{Name} is not valid") { }
}

    
