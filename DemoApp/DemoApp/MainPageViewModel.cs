using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DemoApp
{
    class MainPageViewModel : BaseViewModel
    {
        private int _number1 = 0;
        private int _number2 = 0;
        private int _sum = 0;

        private int _sliderValue = 50;

        private int _increment = 0;

        public MainPageViewModel()
        {
            Title = "UI_Demo";
            AddCommand = new Command(ExecuteAddCommand);
            IncrementCommand = new Command(ExecuteIncrementCommand);
            NavigateCommand = new Command(ExecuteNavigateCommand);
        }

        public string Number1
        {
            get => _number1.ToString();
            set => SetProperty(ref _number1, parseInt(value));
        }

        public string Number2
        {
            get => _number2.ToString();
            set => SetProperty(ref _number2, parseInt(value));
        }

        public int Sum
        {
            get => _sum;
            set => SetProperty(ref _sum, value);
        }

        public int SliderValue
        {
            get => _sliderValue;
            set => SetProperty(ref _sliderValue, value);
        }

        public int Increment
        {
            get => _increment;
            set => SetProperty(ref _increment, value);
        }

        public Command IncrementCommand { get; set; }

        public Command NavigateCommand { get; set; }

        public Command AddCommand { get; set; }

        private void ExecuteIncrementCommand()
        {
            Increment += 1;
        }

        private void ExecuteNavigateCommand()
        {
            ExecuteAddCommand();
            ((Application.Current as App)?.MainPage as NavigationPage)?.PushAsync(new SecondPage(Increment, Sum));
        }

        private void ExecuteAddCommand()
        {
            int number1 = parseInt(Number1);
            int number2 = parseInt(Number2);

            Sum = number1 + number2;
        }

        private int parseInt(String text)
        {
            int number = 0;
            bool success = int.TryParse(text, out number);
            if (!success)
            {
                Console.WriteLine($"\"{text}\" is not a valid number, using 0 instead");
            }

            return number;
        }
    }
}