using System;
using Xamarin.Forms;

namespace navigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Главная страница";

            Button toCommonPageBtn = new Button
            {
                Text = "На обычную страницу",
                TextColor = Color.Black,
                BackgroundColor = Color.Bisque,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            toCommonPageBtn.Clicked += ToCommonPage;

            Button toModalPageBtn = new Button
            {
                Text = "На модальную страницу",
                TextColor = Color.Black,
                BackgroundColor = Color.Bisque,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            toModalPageBtn.Clicked += ToModalPage;

            Content = new StackLayout { 
                Children = { 
                    toCommonPageBtn, toModalPageBtn 
                } 
            };
        }

        private async void ToModalPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalPage());
        }
        private async void ToCommonPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommonPage());
        }
    }
}
