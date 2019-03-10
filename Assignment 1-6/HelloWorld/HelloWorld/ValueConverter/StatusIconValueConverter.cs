using HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace HelloWorld.ValueConverter
{
  public class StatusIconValueConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is Status status)
      {
        switch (status)
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
      return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
