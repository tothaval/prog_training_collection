﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MyNote
{
    /// <summary>
    /// Interaktionslogik für MatrixElement.xaml
    /// </summary>
    public partial class MatrixElement : UserControl
    {
        public int id { get; set; }

        public MatrixElement()
        {
            InitializeComponent();
        }

        public ObservableCollection<Note> extract()
        {
            ObservableCollection<Note> notes = new ObservableCollection<Note>();

            foreach (Note item in SP.Children)
            {
                notes.Add(item);
            }

            return notes;
        }

        public void fill(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                insert();
            }
        }

        public Note insert()
        {
            Note note = new Note();

            SP.Children.Add(note);

            return note;
        }

        public Note insert(Note note)
        {
            SP.Children.Add(note);

            return note;
        }

        public void remove_last_note()
        {
            if (CKX_Delete.IsChecked == true)
            {
                int index = SP.Children.Count - 1;

                if (index > -1)
                {
                    SP.Children.RemoveAt(index);
                }
            }
        }


        private void CKX_Select_Checked(object sender, RoutedEventArgs e)
        {
            CKX_Delete.Visibility = Visibility.Visible;
            CKX_Delete.IsEnabled = true;

            BTN_minus.Visibility = Visibility.Visible;
            BTN_minus.IsEnabled = true;

            BTN_plus.Visibility = Visibility.Visible;
            BTN_plus.IsEnabled = true;

        }

        private void CKX_Select_Unchecked(object sender, RoutedEventArgs e)
        {
            CKX_Delete.Visibility = Visibility.Collapsed;
            CKX_Delete.IsEnabled = false;

            BTN_minus.Visibility = Visibility.Collapsed;
            BTN_minus.IsEnabled = false;

            BTN_plus.Visibility = Visibility.Collapsed;
            BTN_plus.IsEnabled = false;
        }

        private void BTN_minus_Click(object sender, RoutedEventArgs e)
        {
            remove_last_note();
        }

        private void BTN_plus_Click(object sender, RoutedEventArgs e)
        {
            insert();
        }
    }
}
