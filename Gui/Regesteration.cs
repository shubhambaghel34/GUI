using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;
namespace Gui
{
     public class Regesteration : ContentPage
    {
        public Entry ed1,ed3;
        public Editor ed2;
        public Label l2;
       public Regesteration()
        {
            BackgroundColor = Color.FromHex("#4F6785");
            Title = "Regesteration Form";
           
            ed1 = new Entry
            {
             
               Placeholder="Name",
               PlaceholderColor=Color.DarkCyan,
               TextColor=Color.Aqua,
                 VerticalOptions = LayoutOptions.Start,
                 HorizontalOptions = LayoutOptions.StartAndExpand

             };

            
               ed2 = new Editor
            {
                 
               
                 Text="Adddress",
                TextColor = Color.DarkCyan,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.StartAndExpand

            }; ed3 = new Entry
            {

                PlaceholderColor = Color.DarkCyan,
                Placeholder ="Mob.No",
                TextColor = Color.Aqua,
                VerticalOptions=LayoutOptions.Start,
                HorizontalOptions=LayoutOptions.StartAndExpand
            };

            l2 = new Label
            {
             Text="Enter your deatils",
             Style=Device.Styles.TitleStyle,
             HorizontalOptions=LayoutOptions.Center
            };
            Button btn = new Button
            {
                Text = "Submit",
                TextColor = Color.FromHex("#b6d6b4"),
                BackgroundColor = Color.DarkCyan

            };

            btn.Clicked += btn_Clicked;
            Content = new StackLayout
            {
                Spacing = 20,
                Children =
                { 
                    l2,
                     ed1,  
                     ed2,
                     ed3,
                    btn
                },
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Start,

            };
           
           
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
           
            
            if (ed1.Text!=null && ed2.Text!=null && ed3.Text != null)
            {
               
                this.Navigation.PushAsync(new Tabbedpage());
            }
           
        }
    }
}
