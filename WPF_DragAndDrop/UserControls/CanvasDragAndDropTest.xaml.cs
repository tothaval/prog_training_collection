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

namespace WPF_DragAndDrop.UserControls
{
    /// <summary>
    /// Interaktionslogik für CanvasDragAndDropTest.xaml
    /// </summary>
    public partial class CanvasDragAndDropTest : UserControl
    {


        public Brush CanvasBackground
        {
            get { return (Brush)GetValue(CanvasBackgroundProperty); }
            set { SetValue(CanvasBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Color.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CanvasBackgroundProperty =
            DependencyProperty.Register("CanvasBackground", typeof(Brush), typeof(CanvasDragAndDropTest), new PropertyMetadata(Brushes.AntiqueWhite));
     

        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Color.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(Brush), typeof(CanvasDragAndDropTest), new PropertyMetadata(Brushes.Orange));



        public bool IsChildHitTestVisible
        {
            get { return (bool)GetValue(IsChildHitTestVisibleProperty); }
            set { SetValue(IsChildHitTestVisibleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsChildHitTestVisible.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsChildHitTestVisibleProperty =
            DependencyProperty.Register("IsChildHitTestVisible", typeof(bool), typeof(CanvasDragAndDropTest), new PropertyMetadata(true));



        public CanvasDragAndDropTest()
        {
            InitializeComponent();
        }

        private void orangeRectangle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                IsChildHitTestVisible = false;
                DragDrop.DoDragDrop(orangeRectangle, new DataObject(DataFormats.Serializable, orangeRectangle), DragDropEffects.Move);
                IsChildHitTestVisible = true;
            }
        }


        private void canvas_DragOver(object sender, DragEventArgs e)
        {
            Point dropPosition = e.GetPosition(canvas);
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is UIElement element)
            {
                Canvas.SetLeft(element, dropPosition.X);
                Canvas.SetTop(element, dropPosition.Y);

                if (!canvas.Children.Contains(element))
                {
                    canvas.Children.Add(element);
                }
            }
        }

        private void canvas_Drop(object sender, DragEventArgs e)
        {

        }

        private void canvas_DragLeave(object sender, DragEventArgs e)
        {
            if (e.OriginalSource == canvas)
            {
                object data = e.Data.GetData(DataFormats.Serializable);

                if (data is UIElement element)
                {
                    canvas.Children.Remove(element);
                }
            }
        }
    }
}