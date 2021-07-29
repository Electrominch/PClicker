﻿using PClicker.MVVM.Models;
using PClicker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PClicker.ViewModels
{
    class PockerViewModel : BaseViewModel
    {
        private Pocker p = new Pocker();
        public WindowHandle Window
        {
            get { return p.Window; }
            set { p.Window = value; OnPropertyChanged("Window"); }
        }
        public int Id 
        { 
            get { return p.Id; }
        }
        public bool Enable
        { 
            get { return p.Enable; }
            set { p.Enable = value; OnPropertyChanged("Enable"); } 
        }

        private RelayCommand changeEnableCommand;
        public RelayCommand ChangeEnableCommand
        {
            get
            {
                return changeEnableCommand ??
                  (changeEnableCommand = new RelayCommand(obj =>
                  {
                      Enable = !Enable;
                  }));
            }
        }
    }
}
