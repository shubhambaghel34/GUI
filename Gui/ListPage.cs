using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Gui
{
    public class ListPage : ContentPage
    {  
        public ListPage()
        {
            Title = "User logs";
            BackgroundColor = Color.MintCream;
            var listView = new ListView();
            listView.ItemsSource = new string[]{
  "User 1",
  "user 2",
  "user 3",
  "user 4",
  "user 5",
            

        };

            Content = new StackLayout
            {
                Children = {
                   listView
                }
            };
        }
    }
}