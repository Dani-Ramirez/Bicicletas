using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Bicicletas.Base
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyname));
        }
    }
}
