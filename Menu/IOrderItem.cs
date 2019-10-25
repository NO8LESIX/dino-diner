using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem: INotifyPropertyChanged
    {
        double Price { get; }
        string Description {get;}
        string [] Special {get;}
    }
}
