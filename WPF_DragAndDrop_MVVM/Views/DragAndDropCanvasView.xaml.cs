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
using WPF_DragAndDrop_MVVM.Commands;

namespace WPF_DragAndDrop_MVVM.Views
{
    /// <summary>
    /// Interaktionslogik für DragAndDropCanvasView.xaml
    /// </summary>
    public partial class DragAndDropCanvasView : UserControl
    {


        public ICommand RectangleDropCommand
        {
            get { return (ICommand)GetValue(RectangleDropCommandProperty); }
            set { SetValue(RectangleDropCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RectangleDropCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RectangleDropCommandProperty =
            DependencyProperty.Register("RectangleDropCommand", typeof(ICommand), typeof(DragAndDropCanvasView), new PropertyMetadata(null));




        public ICommand RectangleRemoveCommand
        {
            get { return (ICommand)GetValue(RectangleRemoveCommandProperty); }
            set { SetValue(RectangleRemoveCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RectangleRemoveCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RectangleRemoveCommandProperty =
            DependencyProperty.Register("RectangleRemoveCommand", typeof(ICommand), typeof(DragAndDropCanvasView), new PropertyMetadata(null));




        public string RemoveRectangleName
        {
            get { return (string)GetValue(RectangleNameProperty); }
            set { SetValue(RectangleNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RemoveRectangleName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RectangleNameProperty =
            DependencyProperty.Register("RemoveRectangleName", typeof(string), typeof(DragAndDropCanvasView),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));







        public Brush CanvasBackground
        {
            get { return (Brush)GetValue(CanvasBackgroundProperty); }
            set { SetValue(CanvasBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Color.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CanvasBackgroundProperty =
            DependencyProperty.Register("CanvasBackground", typeof(Brush), typeof(DragAndDropCanvasView), new PropertyMetadata(Brushes.AntiqueWhite));


        public Brush Color
        {
            get { return (Brush)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Color.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(Brush), typeof(DragAndDropCanvasView), new PropertyMetadata(Brushes.Orange));



        public bool IsChildHitTestVisible
        {
            get { return (bool)GetValue(IsChildHitTestVisibleProperty); }
            set { SetValue(IsChildHitTestVisibleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsChildHitTestVisible.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsChildHitTestVisibleProperty =
            DependencyProperty.Register("IsChildHitTestVisible", typeof(bool), typeof(DragAndDropCanvasView), new PropertyMetadata(true));




        public DragAndDropCanvasView()
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
            RectangleDropCommand?.Execute(null);
        }

        private void canvas_DragLeave(object sender, DragEventArgs e)
        {
            object data = e.Data.GetData(DataFormats.Serializable);

            if (data is FrameworkElement element)
            {
                RemoveRectangleName = element.Name;
                RectangleRemoveCommand?.Execute(null);
            }

        }
    }
}