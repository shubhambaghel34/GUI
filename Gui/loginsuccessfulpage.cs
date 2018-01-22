using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Gui
{
   public  class loginsuccessfulpage : ContentPage
    {
       
        public loginsuccessfulpage()
        {
            
            Title = "Login";
             
            Label l3 = new Label
            {
              Text="you have been sucessfully login.",
                HorizontalOptions = LayoutOptions.Start


            };
            Content = new Label
            {
                Text = "Username:abc",
                HorizontalOptions=LayoutOptions.Start


            };
            Label l4 = new Label
            {
                Text = "password:abc",
                HorizontalOptions = LayoutOptions.Start


            };
            Button bt = new Button
            {
                Text ="ok",
                TextColor=Color.Red,
                BackgroundColor=Color.FromHex("#430e1e")
           
            };
            bt.Clicked += bt_clicked;

            Content = new StackLayout
            {
                Children =
                {
                     l3,
                     Content,
                     l4,
                     bt
                     
        }
               
                

            };
            

        }

        private void bt_clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Tabbedpage());
           

        }
    }
}
