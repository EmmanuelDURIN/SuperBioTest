using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace SuperBioTest
{
  public class StatusToBrushConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      ReagentStatus status = (ReagentStatus)value;
      switch (status)
      {
        case ReagentStatus.OK:
          return new SolidColorBrush(Color.FromRgb(0, 128, 0));
        case ReagentStatus.Warning:
          return new SolidColorBrush(Color.FromRgb(128,128, 0));
        case ReagentStatus.Alert:
          return new SolidColorBrush(Color.FromRgb(128, 0, 0));
        default:
          return new SolidColorBrush(Color.FromRgb(0, 0, 0));
      }
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
