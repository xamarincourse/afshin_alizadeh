using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HelloWorld.Model
{
  public class FlightStatus
  {
    private FlightStatus()
    {

    }
    public static FlightStatus Create(Status status)
    {
      return new FlightStatus()
      {
        Status = status
      };
    }

    public Status Status { get; set; }

    public string Text
    {
      get
      {
        switch (Status)
        {
          case Status.OnTime:
            return "On-Time";
          case Status.Delay:
            return "Delay";
          case Status.Arrivied:
            return "Arrivied";
          case Status.Scheduled:
            return "Scheduled";
          default:
            throw new NotImplementedException();
        }
      }
    }

    public Color Color
    {
      get
      {
        switch (Status)
        {
          case Status.OnTime:
            return Color.Green;
          case Status.Delay:
            return Color.Red;
          case Status.Arrivied:
            return Color.Blue;
          case Status.Scheduled:
            return Color.Orange;
          default:
            throw new NotImplementedException();
        }
      }
    }

    public string Font
    {
      get
      {
        switch (Status)
        {
          case Status.OnTime:
            return "\uf00c";
          case Status.Delay:
            return "\uf017";
          case Status.Arrivied:
            return "\uf5af";
          case Status.Scheduled:
            return "\uf5b0";
          default:
            throw new NotImplementedException();
        }
      }
    }
  }

  public enum Status
  {
    OnTime, Delay, Arrivied, Scheduled
  }
}
