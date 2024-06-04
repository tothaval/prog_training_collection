using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DataSavingAndLoading
{
    public class CSV_Data
    {
        public static DataView GetCSVData(string path)
        {
            DataTable dt = new DataTable();

            TextFieldParser textFieldParser = new TextFieldParser(path);
            textFieldParser.SetDelimiters(";"); // what if delimiter is comma, a check would be needed.

            if (!textFieldParser.EndOfData)
            {
                var columns = textFieldParser.ReadFields();

                foreach (var col in columns)
                {
                    dt.Columns.Add(col);
                }
            }

            while (!textFieldParser.EndOfData)
            {
                var row = textFieldParser.ReadFields();

                dt.Rows.Add(row);
            }

            return dt.DefaultView;
        }
    }
}
