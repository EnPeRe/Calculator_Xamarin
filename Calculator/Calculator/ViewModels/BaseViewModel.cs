using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Calculator.ViewModels
{
    public class BaseViewModel
    {
        #region Properties
        public event PropertyChangedEventHandler propertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
