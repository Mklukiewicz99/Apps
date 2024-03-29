﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.core
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged = (s, e) => { };

        protected void OnPropertyChanged(string name) 
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nameof(name)));
        }
    }
}
