using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Gui
{
    
    public class Mainpage : ContentPage
    {

        private Entry _password, _username;


        

        public Mainpage()
           {

           
            StackLayout s1 = new StackLayout();
            BackgroundColor = Color.FromHex("#174873");
            Title = "Login";
            _username = new Entry
            {
                Placeholder = "Username"

               };
            _password = new Entry
            {
                Placeholder = "Password",
                IsPassword = true
            };

            Button b1 = new Button
            {
                Text = "login",
                BackgroundColor=Color.Accent
               
                
               

            };
            Button b2 = new Button
            {
                Text = "New user?",
                BackgroundColor = Color.Peru,
                HorizontalOptions = LayoutOptions.CenterAndExpand


            };
            
            b1.Clicked += b1_Clicked;
            b2.Clicked += b2_Clicked;

            s1.Children.Add(b1);
            
            Content = new StackLayout
            {
               

                Children =
                {
                    _username,
                  _password,
                  b1,
                  b2,
                  
                  
                    

                },
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                


            };


        }

        private void b2_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Regesteration());
        }

        private void b1_Clicked(object sender, EventArgs e)
        {
            

            if (_username.Text == "abc"  && _password.Text == "abc")
            {
                this.Navigation.PushAsync(new loginsuccessfulpage());
                 DisplayAlert("login", "You have been login", "ok");




            }
            else
            {
                this.Navigation.PushAsync(new Regesteration());
                this.Navigation.PopAsync();
                
            }
           
        }
        
    }
    }
