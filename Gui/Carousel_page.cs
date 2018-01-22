using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Gui
{
    public class Carousel_page: CarouselPage
    {
        public Carousel_page()
        {

            var Page1 = new ContentPage
            {
                BackgroundColor = Color.BurlyWood,
                Content = new StackLayout
                {
                    Children = {
                    new Label {
                        Text = "Page1",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new BoxView {
                        Color = Color.Red,
                        WidthRequest = 400,
                        HeightRequest = 400,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
                },

            };
            var Page2 = new ContentPage
            {
              BackgroundColor=Color.CornflowerBlue,
                Content = new StackLayout
                {
                    Children = {
                    new Label {
                        Text = "Page2",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new BoxView {
                        Color = Color.Aquamarine,
                        WidthRequest = 300,
                        HeightRequest = 300,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
                },

            };
            var Page3 = new ContentPage
            {
              BackgroundColor=Color.Crimson,
                Content = new StackLayout
                {
                    Children = {
                    new Label {
                        Text = "Page3",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new BoxView {
                        Color = Color.Beige,
                        WidthRequest = 550,
                        HeightRequest = 550,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
                },

            };
            Children.Add(Page1);
            Children.Add(Page2);
            Children.Add(Page3);

        }
    }
}
