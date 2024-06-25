using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
/*
The programs task is to determine new costs
for a shared living apartment on a per room
basis. There is a rental share, which is 
dependend on area share of the room in relation
to the total area of the flat/apartment.
And there is an extra costs share, which is
a composition of fixed costs based on area 
share and costs based on the consumption
of heating units per billing period, as
well as on heating units consumption of
the shared area divided by the number of rooms.

Necessary data items are:
total number of rooms
total area of flat/apartment
area per room
initial rent 
initial extra costs advance
updated rent
updated extra costs advanced
(based on heating units consumption)
updated heating units usage per room
payments per room for billing period
(they may vary over a billing period)
a billig period (annual, quarterly)

Required data output is:
rental area share per room
extra costs advance share per room
updated rental area share per room on raise
updated extra costs advance share per room after annual billing,
taking into account consumption of heating units. Higher usage
should lead to an higher advance, to take the habits of the tenant
into account and therefor reduce the impact of an annual billing,
which would be higher if the extra costs advance is based on area
shares only.  
*/
namespace FlatShareCostCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FlatData flatData = new FlatData();
        private FlatCosts flatCosts = new FlatCosts();

        private ObservableCollection<CostUpdateData> costUpdates = new ObservableCollection<CostUpdateData>();

        private AUX_XML_Handler xml_handler = new AUX_XML_Handler();

        public MainWindow()
        {
            InitializeComponent();

            if (!load_data())
            {
                FlatDataUI_object.focus();
            }
            else 
            {
                FlatDataUI_object.load_data(flatData);
                InitialCostsUI_object.load_data(flatCosts);
            }

            load_costUpdates();

        }

        internal void addCostUpdate(CostUpdateData costUpdate) 
        { 
            costUpdates.Add(costUpdate);
        }

        internal ObservableCollection<CostUpdateData> getCostUpdates()
        {
            return costUpdates;
        }


        internal FlatCosts getFlatCosts()
        {
            return flatCosts;
        }

        internal FlatData getFlatData()
        {
            return flatData;
        }

        private bool load_costUpdates()
        {
            bool loadable_data_detected = false;

            costUpdates = xml_handler.load_cost_update_from_xml();

            if (costUpdates == null)
            {
                return loadable_data_detected = false;
            }

            foreach (CostUpdateData item in costUpdates)
            {
                UpdateCostsUI_object.add_UpdateCosts(item);
            }

            loadable_data_detected = true;            

            return loadable_data_detected;
        }


        private bool load_data()
        {
            bool loadable_data_detected = false;
            ObservableCollection<object> data = xml_handler.load_data_from_xml();

            if (data == null)
            {
                return loadable_data_detected = false;
            }

            foreach (object item in data)
            {
                if (item.GetType() == typeof(FlatData))
                {
                    flatData = (FlatData)item;
                }
                else if (item.GetType() == typeof(FlatCosts))
                {
                    flatCosts = (FlatCosts)item;
                }
            }

            loadable_data_detected = true;

            return loadable_data_detected;
        }

        internal void removeCostUpdate(CostUpdateData costUpdateData)
        {
            costUpdates.Remove(costUpdateData);
        }

        internal void save_data(FlatData data)
        {
            this.flatData = data;

            xml_handler.save_data_to_xml(flatData, flatCosts);
            
            InitialCostsUI_object.focus();
        }

        internal void save_data(FlatCosts costs)
        {
            this.flatCosts = costs;

            xml_handler.save_data_to_xml(flatData, flatCosts);
        }

        internal void save_costUpdates()
        {
            TabControl tabControl = UpdateCostsUI_object.MainTabControl;
            AUX_IO_Handler iO_Handler = new AUX_IO_Handler();

            // alle dateien löschen
            iO_Handler.delete_files(iO_Handler.xml_folder_path, iO_Handler.data_path);


            foreach (TabItem tab_item in tabControl.Items)
            {
                UpdateCosts cost_update_item = (UpdateCosts)tab_item.Content;

                cost_update_item.save_costUpdate();
            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            save_data(flatCosts);
            save_data(flatData);
            save_costUpdates();
        }
    }
}
