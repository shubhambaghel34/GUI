using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Gui
{
    public class Tabbedpage : TabbedPage
    {

        public Tabbedpage()
        {
            Title = "My Details";
            this.Children.Add(new loginsuccessfulpage());
            this.Children.Add(new Regesteration());
            this.Children.Add(new ListPage());

        }
    }
}
