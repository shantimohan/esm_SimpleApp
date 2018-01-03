using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

// This is a practice app to get started with Xamarin and using LivePlayer
//    following steps as described at https://aka.ms/get-started for the contest
//    as detailed in this blog post https://blog.xamarin.com/contest-get-started-xamarin/

namespace SimpleApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button1_Clicked(Object sender, EventArgs e)
        {
            Label1.Text = "Monkey is Ready to Fly!!!";
        }

    }
}
