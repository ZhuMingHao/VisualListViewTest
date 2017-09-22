using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace VisualListViewTest
{
   public class ImageConverter : IValueConverter

    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
