using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using HelloWorld.Model;

namespace HelloWorld.ValueConverter
{
  public class StatusTextValueConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is Status status)
      {
        switch (status)
        {
          case HelloWorld.Model.Status.OnTime:
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

      return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
