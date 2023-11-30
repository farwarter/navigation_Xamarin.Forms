using System;
using Xamarin.Forms;

namespace navigation
{
    public class ModalPage : ContentPage
    {
        public ModalPage()
        {
            Title = "Модальная страница";

            Button galleryButton = new Button { 
                Text = "Галерея",
                TextColor = Color.Black,
                BackgroundColor = Color.Bisque,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            galleryButton.Clicked += GalleryButton_Click;

            Button backButton = new Button {
                Text = "На главную",
                TextColor = Color.Black,
                BackgroundColor = Color.Bisque,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            backButton.Clicked += BackButton_Click;

            Content = new StackLayout { 
                Children = { 
                    galleryButton, backButton 
                } 
            };
        }

        private async void GalleryButton_Click(object sender, EventArgs e)
        {
            GalleryPage galPage = new GalleryPage();
            await Navigation.PushModalAsync(galPage);
        }
        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}