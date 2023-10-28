﻿using System;
using System.ComponentModel;
namespace MVVMEx
{
    public class BaseViewModel : INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged;
		
            protected void OnPropertyChanged(string propertyName)
            {
                var handler = PropertyChanged;
                if (handler != null)
                    handler(this, new PropertyChangedEventArgs(propertyName));
            }
        public BaseViewModel()
        {
        }
    }
}

