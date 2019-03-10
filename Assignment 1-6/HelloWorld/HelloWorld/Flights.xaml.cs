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
  public partial class Flights : ContentPage
  {
    public List<Flight> flights;
    public Flights()
    {
      InitializeComponent();

      var mahan = new Airline()
      {
        Name = "Mahan",
        Image = ImageSource.FromResource("HelloWorld.Images.Airline.W5.png", GetType().GetTypeInfo().Assembly)
      };

      var turkishAirlines = new Airline()
      {
        Name = "Turkish Airlines",
        Image = ImageSource.FromResource("HelloWorld.Images.Airline.TK.png", GetType().GetTypeInfo().Assembly)
      };

      var iranAir = new Airline()
      {
        Name = "Iran Air",
        Image = ImageSource.FromResource("HelloWorld.Images.Airline.IR.png", GetType().GetTypeInfo().Assembly)
      };

      var emirates = new Airline()
      {
        Name = "Emirates",
        Image = ImageSource.FromResource("HelloWorld.Images.Airline.EK.png", GetType().GetTypeInfo().Assembly)
      };

      flights = new List<Flight>()
      {
        new Flight()
        {
          Airline =mahan,
          ArrivalAirport = "IKA",
          DepartureAirport = "DXB",
          Ata = DateTime.Now.AddHours(3),
          Atd = DateTime.Now.AddHours(1),
          FlightNumber = "W5 061",
          FlightStatus  = FlightStatus.Create(Status.Arrivied)
        },
        new Flight()
        {
          Airline = turkishAirlines,
          ArrivalAirport = "IKA",
          DepartureAirport = "DUS",
          Ata = DateTime.Now.AddHours(7),
          Atd = DateTime.Now.AddHours(2),
          FlightNumber = "W5 1020",
          FlightStatus  = FlightStatus.Create(Status.Delay)
        },
        new Flight()
        {
          Airline = emirates,
          ArrivalAirport = "IKA",
          DepartureAirport = "MXP",
          Ata = DateTime.Now.AddHours(4),
          Atd = DateTime.Now.AddHours(0.5),
          FlightNumber = "W5 2065",
          FlightStatus  = FlightStatus.Create(Status.OnTime)
        },
        new Flight()
        {
          Airline = iranAir,
          ArrivalAirport = "IKA",
          DepartureAirport = "IST",
          Ata = DateTime.Now.AddHours(4),
          Atd = DateTime.Now.AddHours(1),
          FlightNumber = "W5 126",
          FlightStatus  = FlightStatus.Create(Status.Scheduled)
        }
      };

      flightListView.ItemsSource = flights;

    }
  }
}