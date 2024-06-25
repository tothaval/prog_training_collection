﻿using System;
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

namespace MyNote
{
    /// <summary>
    /// Interaktionslogik für ActivityTab.xaml
    /// </summary>
    public partial class ActivityTab : UserControl
    {
        private StringBuilder history = new StringBuilder();

        public ActivityTab()
        {
            InitializeComponent();

            loadHistory();

            history.Insert(0, "\n");
            history_entry("MyNote activation");
        }

        public StringBuilder application_closing()
        {
            history_entry("saving complete");
            history_entry("MyNote deactivation");

            return history;
        }

        private void history_clear()
        {
            history.Clear();

            history_entry("history cleared");
        }

        public void history_entry(string entry)
        {
            history.Insert(0, $"{DateTime.Now} {entry}\n");

            //history.AppendLine($"{DateTime.Now} {entry}");

            TB_History.Text = history.ToString();
        }

        public void loadHistory()
        {
            history.Clear();

            history = new XML_Handler().load_history_from_xml();

        }

        private void BT_ClearHistory_Click(object sender, RoutedEventArgs e)
        {
            history_clear();
        }
    }
}
