using HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace HelloWorld.ValueConverter
{
  public class StatusColorValueConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is Status status)
      {
        switch (status)
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

      return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
