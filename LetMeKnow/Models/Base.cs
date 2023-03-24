using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LetMeKnow.Models;

public class Base:INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged; 
    public void OnPropertyChanged([CallerMemberName] string propertyName = "")=>
        PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
}
