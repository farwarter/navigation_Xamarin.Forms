using System;
using Xamarin.Forms;

namespace navigation
{
    public class GalleryPage : ContentPage
    {
        public GalleryPage()
        {
            Image image1 = new Image { Source = "capi1.png" };
            Image image2 = new Image { Source = "capi2.png" };
            Image image3 = new Image { Source = "capi3.jpg" };

            Button backButton = new Button
            {
                Text = "Назад",
                TextColor = Color.Black,
                BackgroundColor = Color.Bisque,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            backButton.Clicked += BackButton_Click;

            StackLayout stackLayout = new StackLayout()
            {
                Children = {
                    new Label { 
                        Text = "Капибары!",
                        FontSize = 20,
                        TextColor = Color.Black,
                        BackgroundColor = Color.White,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    },
                    backButton,image1,image2,image3
                }
            };
            stackLayout.Spacing = 8;
            ScrollView scrollView = new ScrollView();
            scrollView.Content = stackLayout;
            this.Content = scrollView;

            async void BackButton_Click(object sender, EventArgs e)
            {
                await Navigation.PopModalAsync();
            }
        }
    }
}