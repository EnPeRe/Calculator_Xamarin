using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculator.Controls
{
    public partial class CalculatorControl : StackLayout
    {

        public CalculatorControl ()
		{
			InitializeComponent ();
		}

        public static readonly BindableProperty OperationTextProperty = BindableProperty.Create("OperationText",
            typeof(string), typeof(CalculatorControl),
            default(ICommand), BindingMode.TwoWay,
            propertyChanged: OnResultChange);

        public string OperationText
            { 
                get {return ((string) GetValue(OperationTextProperty));}
                set
                {
                    SetValue(OperationTextProperty, value);
                }
            }

        public static void OnResultChange(BindableObject bindable, object oldValue, object newValue)
        {
            CalculatorControl control = bindable as CalculatorControl;
            if(control != null && oldValue != newValue)
            {
                //Hacemos algo
            }
        }

        public static readonly BindableProperty CalculateCommandProperty = BindableProperty.Create("CalculateCommand",
            typeof(ICommand), typeof(CalculatorControl),
            default(ICommand), BindingMode.TwoWay);

        public ICommand CalculateCommand
        {
            get { return ((ICommand)GetValue(CalculateCommandProperty)); }
            set
            {
                SetValue(CalculateCommandProperty, value);
            }
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            OperationText += button.Text;
        }

	}
}