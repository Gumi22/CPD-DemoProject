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

        private void UpdateMyLabel(object sender, EventArgs e)
        {
            MyLabel.Text = MyTextInput.Text;
        }
    }
}
