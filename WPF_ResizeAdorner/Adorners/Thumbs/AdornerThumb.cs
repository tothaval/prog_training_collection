using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace WPF_ResizeAdorner.Adorners.Thumbs
{
    internal class AdornerThumb : Thumb, IThumb
    {
        public AdornerThumb()
        {
            Width = 10;
            Height = 10;

            Background = Brushes.Coral;
        }

        public void ResetThumb(double width, double height, Brush background)
        {
            Width = width;
            Height = height;

            Background = background;
        }
    }
}
