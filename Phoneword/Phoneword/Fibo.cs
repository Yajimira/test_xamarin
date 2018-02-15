using System;
namespace Phoneword
{
    public class Fibo : ContentPage
    {
        private double stepValue;
        public Fibo()
        {
            stepValue = 1.0;

            SliderMain = new Slider
            {
                Minimum = 0.0f,
                Maximum = 5.0f,
                Value = 0.0f,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            SliderMain.ValueChanged += OnSliderValueChanged;

            Content = new StackLayout
            {
                Children = { SliderMain },
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / StepValue);

            SliderMain.Value = newStep * StepValue;
        }
        }
    }
}
