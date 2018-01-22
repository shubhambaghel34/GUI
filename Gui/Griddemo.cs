using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Gui
{
   public  class Carouselpage: ContentPage
    {
        private Grid grid;
        private Label  l2, l1,l3,l4;
       
        public Carouselpage()
        {

            grid = new Grid
            {
                ColumnSpacing = 5,
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions = new RowDefinitionCollection
                {
                new RowDefinition
                  {

                   Height=new GridLength(1,GridUnitType.Star)},
                 new RowDefinition
                  {

                   Height=new GridLength(1,GridUnitType.Star)},


                },
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                 new ColumnDefinition
                 {
                     Width=new GridLength(1,GridUnitType.Star)
                 },
                   new ColumnDefinition
                 {
                     Width=new GridLength(1,GridUnitType.Star)
                 },

                }

            };
       
            l1 = new Label
            {
                Text = "label 1",
                BackgroundColor=Color.Red,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.StartAndExpand,
            };
            l2 = new Label
            {
                Text = "Label 2",
                BackgroundColor = Color.Ivory,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.StartAndExpand,
              
            };
            l3= new Label
            {
                Text = "Label 3",
                BackgroundColor = Color.DarkCyan,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.StartAndExpand,

            };
            l4 = new Label
            {
                Text = "Label 4",
                BackgroundColor = Color.Gainsboro,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.StartAndExpand,

            };
           




            grid.Children.Add(l1, 0, 0);
            grid.Children.Add(l2, 0 , 1);
            grid.Children.Add(l3, 1, 0);
            grid.Children.Add(l4, 1, 1);
           
            Content = grid;
           
        }
        
        
    }
    

}
