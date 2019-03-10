using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    async void Flighs_Clicked(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new Flights());
    }

    async void Activities_Clicked(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new MyFlights());
    }
  }
}
