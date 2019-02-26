﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HelloWorld.Model
{
  public class Flight
  {
    public string DepartureAirport { get; set; }
    public string ArrivalAirport { get; set; }
    public DateTime Sta { get; set; }
    public DateTime Std { get; set; }

    public DateTime Ata { get; set; }
    public DateTime Atd { get; set; }

    public string Airline { get; set; }

    public ImageSource AirlineLogo { get; set; }

    public string FlightNumber { get; set; }

    public string Status { get; set; }
  }
}
