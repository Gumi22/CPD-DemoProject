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
            int number1 = parseInt(MyTextInputNumberOne.Text);
            int number2 = parseInt(MyTextInputNumberTwo.Text);

            int sum = number1 + number2;

            LabelSumOutput.Text = sum.ToString();
        }

        private int parseInt(String text)
        {
            int number = 0;
            bool success = int.TryParse(text, out number);
            if (!success)
            {
                Console.WriteLine("not a valid number");
            }
            return number;
        }

        private void SliderNumber_ValueChanged(object sender, ValueChangedEventArgs valueChangedEventArgs)
        {
            LabelSliderOutput.Text = SliderNumber.Value.ToString();
        }
    }
}
