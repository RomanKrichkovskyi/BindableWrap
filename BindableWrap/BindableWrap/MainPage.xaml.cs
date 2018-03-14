using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindableWrap
{
	public partial class MainPage : ContentPage
	{
        public List<string> ListName { get; set; }
		public MainPage()
		{
			InitializeComponent();
            ListName = new List<string> { "Joni", "Toni", "Archi", "Joni", "Tonieeee", "Archwei" };
            StackL.ItemsSource = ListName;

        }
	}
}
