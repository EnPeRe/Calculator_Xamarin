using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculator.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private string operation;

        public string Operation
        {
            get
            {
                return operation;
            }
            set
            {
                operation = value;
                OnPropertyChanged();
            }
        }

        private ICommand resultCommand;

        public ICommand ResultCommand
        {
            get
            {
                resultCommand = resultCommand ?? new Command(() => this.GenerateResult());
                return resultCommand;
            }
        }

        private void GenerateResult()
        {

        }

    }
}
