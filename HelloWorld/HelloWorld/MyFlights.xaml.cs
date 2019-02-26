using HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyFlights : ContentPage
	{
		public MyFlights ()
		{
			InitializeComponent ();

      var ticket = new Ticket()
      {
        Airline = "Mahan",
        AirlineLogo = ImageSource.FromResource("HelloWorld/Images/mahan-airline-logo-fara.png", GetType().GetTypeInfo().Assembly),
        ArrivalAirport = "DXB",
        Ata = DateTime.Now.AddHours(2),
        Atd = DateTime.Now.AddMinutes(10),
        BoardingDateTime = DateTime.Now,
        DepartureAirport = "IKA",
        FlightNumber = "W5 0061",
        Gate = "A5",
        Seat = "A10",
        Sta = DateTime.Now.AddHours(2),
        Std = DateTime.Now,
        Term = "1",
        Status= "ON-Time"
      };

      this.BindingContext = ticket;
		}
	}
}