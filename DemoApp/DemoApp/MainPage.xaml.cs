using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonSum_Clicked(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;

            if(!int.TryParse(MyTextInputNumberOne.Text, out number1))
            {
                number1 = 0;
            }
            if (!int.TryParse(MyTextInputNumberTwo.Text, out number2))
            {
                number2 = 0;
            }

            int sum = number1 + number2;

            LabelSumOutput.Text = sum.ToString();
        }

        private void SliderNumber_ValueChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            LabelSliderOutput.Text = SliderNumber.Value.ToString();
        }
    }
}
