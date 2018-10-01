using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DemoApp
{
    class SimpleViewModel : BaseViewModel
    {
        private string _text = string.Empty;
        private string _input = string.Empty;



        public SimpleViewModel()
        {
            Title = "UI_Demo";
            Text = "Hello";
            ButtonCommand = new Command(ExecuteButtonCommand);
            NavigateCommand = new Command(ExecuteNavigateCommand);
        }

        public string Text { get => _text; set => SetProperty(ref _text, "Hello " + value + "!"); }
        public string Input { get => _input; set => SetProperty(ref _input, value); }
        public Command ButtonCommand { get; set; }

        public Command NavigateCommand { get; set; }

        private void ExecuteButtonCommand()
        {
            Text = Input;
        }

        private void ExecuteNavigateCommand()
        {
            ((Application.Current as App)?.MainPage as NavigationPage)?.PushAsync(new SecondPage());
        }
    }
}
