using System;
using Xamarin.Forms;

namespace Phoneword
{
    public partial class FibbonacciPage : ContentPage
    {
        private double stepValue;
        private Slider SliderMain;
        private Label number;
        private Label fibo;
        public FibbonacciPage()
        {
            stepValue = 1.0;

            SliderMain = new Slider
            {
                Minimum = 0.0f,
                Maximum = 12.0f,
                Value = 0.0f,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            SliderMain.ValueChanged += OnSliderValueChanged;
            number = new Label();
            fibo = new Label();

            Content = new StackLayout
            {
                Children = { SliderMain, number, fibo },
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / stepValue);

            SliderMain.Value = newStep * stepValue;
            number.Text = SliderMain.Value.ToString();
            fibo.Text = Fibonumber(SliderMain.Value).ToString();
        }
        private double Fibonumber(double n)
        {
            if(n<=1.0){
                return n;
            }
            if(n>=12.0){
                return 100;
            }
            return (Fibonumber(n - 1)) + (Fibonumber(n - 2));
        }
    }
}