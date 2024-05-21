using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Training8
{
    public class DateTab : Tab
    {
        public DateTab()
        {
            Name = DateTime.Now.ToString();
        }
    }
}
