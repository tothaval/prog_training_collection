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

namespace ColorPickerTool
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Color color = new Color();
        private SolidColorBrush brush = new SolidColorBrush();
        private int Rot = -1;
        private int Grün = -1;
        private int Blau = -1;
        private int Grau = -1;
        private int Helligkeit = -1;
        private int Alpha = -1;

        private bool load = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private Color colorCanvas(int alpha, int red, int green, int blue)
        {   
            color.A = ((byte)alpha);
            color.R = ((byte)red);
            color.G = ((byte)green);
            color.B = ((byte)blue);
            
            brush.Color = color;
            canvas.Background = brush;

            colorChanged(alpha, red, green, blue);

            return color;
        }

        private void colorChanged(int alpha, int red, int green, int blue)
        {
            lblARGBValue.Content = argb(alpha, red, green, blue);
            lblRGBValue.Content = rgb(red, green, blue);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sldRot.Value = 100;
            Rot = 100;
            sldGrün.Value = 100;
            Grün = 100;
            sldBlau.Value = 100;
            Blau = 100;
            sldGrau.Value = 100;
            Grau = 100;
            sldHelligkeit.Value = 0;
            Helligkeit = 0;
            sldAlpha.Value = 255;
            Alpha = 255;

            color = colorCanvas(Alpha,Rot,Grün,Blau);

            lblRGBValue.Content = rgb(Rot, Grün, Blau);
            lblARGBValue.Content = argb(Alpha, Rot, Grün, Blau);

            load = false;
        }

        private string rgb(int red, int green, int blue)
        {
            return red.ToString() + "," + green.ToString() + "," + blue.ToString();
        }

        private string argb(int alpha, int red, int green, int blue)
        {
            return alpha.ToString() + "," + red.ToString() + "," + green.ToString() + "," + blue.ToString();
        }

        private void sldRot_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (load==false)
            {
                var sld_rot = sender as Slider;


                Rot = (int)sld_rot.Value;
                colorCanvas(Alpha, Rot, Grün, Blau);
                lblRedValue.Content = Rot.ToString();
            }            
        }

        private void sldGrün_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (load == false)
            {
                var sld_grün = sender as Slider;


                Grün = (int)sld_grün.Value;
                colorCanvas(Alpha, Rot, Grün, Blau);
                lblGreenValue.Content = Grün.ToString();
            }
        }

        private void sldBlau_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (load == false)
            {
                var sld_blau = sender as Slider;


                Blau = (int)sld_blau.Value;
                colorCanvas(Alpha, Rot, Grün, Blau);
                lblBlueValue.Content = Blau.ToString();
            }
        }

        private void sldGrau_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (load == false)
            {
                var sld_grau = sender as Slider;

                Grau = (int)sld_grau.Value;
                colorCanvas(Alpha, Grau, Grau, Grau);
                lblGreyValue.Content = Grau.ToString();
                sldBlau.Value = Grau;
                sldGrün.Value = Grau;
                sldRot.Value = Grau;
            }
        }

        private int colorValueViolation(int _color)
        {
            if (_color > 255)
            {
                return 255;
            }

            if (_color < 0)
            {
                return 0;
            }

            else return _color;
            
        }

        private void sldHelligkeit_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {   
            if (load == false)
            {
                var sld_helligkeit = sender as Slider;
                double lblValue = Helligkeit;


                Helligkeit = (int)sld_helligkeit.Value;                             

                int _rot, _grün, _blau = 0;
                _rot = Rot + Helligkeit;
                _grün = Grün + Helligkeit;
                _blau = Blau + Helligkeit;

                color = colorCanvas(Alpha, colorValueViolation(_rot), colorValueViolation(_grün), colorValueViolation(_blau));

                lblRedValue.Content = colorValueViolation(_rot).ToString();                
                lblGreenValue.Content = colorValueViolation(_grün).ToString();
                lblBlueValue.Content = colorValueViolation(_blau).ToString();

                lblBrightnessValue.Content = Helligkeit;

                if (sldHelligkeit.Value > lblValue)
                {
                    sldRot.Value += sldHelligkeit.Value-lblValue;
                    sldGrün.Value += sldHelligkeit.Value - lblValue;
                    sldBlau.Value += sldHelligkeit.Value - lblValue;
                }
                else
                {
                    sldRot.Value -= lblValue - sldHelligkeit.Value;
                    sldGrün.Value -= lblValue - sldHelligkeit.Value;
                    sldBlau.Value -= lblValue - sldHelligkeit.Value;
                }
            }
        }

        private void sldAlpha_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (load==false)
            {
                var sld_alpha = sender as Slider;

                Alpha = (int)sld_alpha.Value;
                colorCanvas(Alpha, Rot, Grün, Blau);
                lblAlphaValue.Content = Alpha.ToString();
            }   
        }
    }
}
