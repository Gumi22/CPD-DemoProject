using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
    public class BaseViewModel : ObservableObject
    {
        private string _title = string.Empty;

        public string Title { get => _title; set => SetProperty( ref _title,  value); }
    }
}
