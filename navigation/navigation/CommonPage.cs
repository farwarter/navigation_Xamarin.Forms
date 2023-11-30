using System;
using Xamarin.Forms;

namespace navigation
{
    public class CommonPage : ContentPage
    {
        public CommonPage()
        {
            Title = "Обычная страница";

            Button colorButton = new Button {
                Text = "Изменить цвет фона на случайный",
                TextColor = Color.Black,
                BackgroundColor = Color.Bisque,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            colorButton.Clicked += ColorButton_Click;

            Button backButton = new Button
            {
                Text = "На главную",
                TextColor = Color.Black,
                BackgroundColor = Color.Bisque,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            backButton.Clicked += BackButton_Click;

            Content = new StackLayout {
                Children = { 
                    colorButton, backButton
                } 
            };
        }

        private Color RandomRGB(Color c)
        {
            Random rand = new Random();
            int max = byte.MaxValue + 1; // 256
            int r = rand.Next(max);
            int g = rand.Next(max);
            int b = rand.Next(max);
            Color col = Color.FromRgb(r, g, b);
            return col;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Color color = Color.Coral;
            BackgroundColor = RandomRGB(color);
        }

        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}