using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace WPF_ResizeAdorner.Adorners.Thumbs
{
    internal interface IThumb
    {
        public void ResetThumb(double width, double height, Brush background);
    }
}
