using System.Runtime.CompilerServices;

namespace LetMeKnow.Models;

public class Base
{
    public event PropertyChangingEventHandler PropertyChanged; 
    public void OnPropertyChanged([CallerMemberName] string propertyName = "")=>
        PropertyChanged?.Invoke(this,new PropertyChangingEventArgs(propertyName));
}
