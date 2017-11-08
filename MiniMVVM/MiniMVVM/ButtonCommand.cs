using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MiniMVVM.ViewModels;

namespace MiniMVVM
{
    public class ButtonCommand:ICommand
    {
        private Action WhattoExecute;
        private Func<bool> WhentoExecute;

        public ButtonCommand(Action what,Func<bool> when)
        {
            WhattoExecute = what;
            WhentoExecute = when;
        }


        public bool CanExecute(object parameter)
        {
            return WhentoExecute();
        }

        public void Execute(object parameter)
        {
            WhattoExecute();
        }

        public event EventHandler CanExecuteChanged;
    }
}
