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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM_Training_4.Components
{
    /// <summary>
    /// Interaktionslogik für TierCard.xaml
    /// </summary>
    public partial class TierCard : UserControl
    {
        public object Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(object), typeof(TierCard), new PropertyMetadata(string.Empty));


        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Description.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(TierCard), new PropertyMetadata(string.Empty));



        public SolidColorBrush RectangleFill
        {
            get { return (SolidColorBrush)GetValue(RectangleFillProperty); }
            set { SetValue(RectangleFillProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RectangleFill.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RectangleFillProperty =
            DependencyProperty.Register("RectangleFill", typeof(SolidColorBrush), typeof(TierCard), new PropertyMetadata(new SolidColorBrush(Colors.Yellow)));


        public static readonly RoutedEvent JoinClickEvent =
            EventManager.RegisterRoutedEvent(
                nameof(JoinClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TierCard));


        public event RoutedEventHandler JoinClick
        {
            add { AddHandler(JoinClickEvent, value);}
            remove { RemoveHandler(JoinClickEvent, value);}
        }



        public TierCard()
        {
            InitializeComponent();
        }

        private void OnJoinClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(JoinClickEvent));
        }
    }
}
