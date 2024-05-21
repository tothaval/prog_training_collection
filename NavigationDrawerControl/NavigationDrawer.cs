using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavigationDrawerControl
{
    /// <summary>
    /// 
    /// </summary>
    public class NavigationDrawer : Control
    {


        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsOpen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool),
                typeof(NavigationDrawer), new PropertyMetadata(false, OnIsOpenPropteryChanged));



        public double FallbackOpenWidth
        {
            get { return (double)GetValue(FallbackOpenWidthProperty); }
            set { SetValue(FallbackOpenWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FallbackOpenWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FallbackOpenWidthProperty =
            DependencyProperty.Register("FallbackOpenWidth", typeof(double), typeof(NavigationDrawer), new PropertyMetadata(100.0));


        public Duration OpenCloseDuration
        {
            get { return (Duration)GetValue(OpenCloseDurationProperty); }
            set { SetValue(OpenCloseDurationProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OpenCloseDuration.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OpenCloseDurationProperty =
            DependencyProperty.Register("OpenCloseDuration", typeof(Duration),
                typeof(NavigationDrawer), new PropertyMetadata(Duration.Automatic));



        public FrameworkElement Content
        {
            get { return (FrameworkElement)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Content.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(FrameworkElement),
                typeof(NavigationDrawer), new PropertyMetadata(null));


        static NavigationDrawer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NavigationDrawer), new FrameworkPropertyMetadata(typeof(NavigationDrawer)));
        }

        public NavigationDrawer()
        {
            Width = 0;
        }

        private static void OnIsOpenPropteryChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is NavigationDrawer navigationDrawer)
            {
                navigationDrawer.OnIsOpenPropteryChanged();
            }
        }

        private void OnIsOpenPropteryChanged()
        {
            if (IsOpen)
            {
                OpenMenuAnimated();
            }
            else
            {
                CloseMenuAnimated();                    
            }
        }


        private void OpenMenuAnimated()
        {
            double contentWidth = GetDesiredContentWidth();

            DoubleAnimation openingAnimation = new DoubleAnimation(contentWidth, OpenCloseDuration);
            BeginAnimation(WidthProperty, openingAnimation);
        }

        private double GetDesiredContentWidth()
        {
            if (Content == null)
            {
                return FallbackOpenWidth;
            }

            Content.Measure(new Size(MaxWidth, MaxHeight));

            return Content.DesiredSize.Width;
        }

        private void CloseMenuAnimated()
        {
            DoubleAnimation closingAnimation = new DoubleAnimation(0, OpenCloseDuration);
            BeginAnimation(WidthProperty, closingAnimation);
        }
    }
}
