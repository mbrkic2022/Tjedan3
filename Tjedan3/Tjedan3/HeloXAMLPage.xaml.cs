using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tjedan3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeloXAMLPage : ContentPage
    {
        public HeloXAMLPage()
        {
            InitializeComponent();
        }

        private void helloSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            sliderLabel.Text=e.NewValue.ToString("F3");
        }
    }
}