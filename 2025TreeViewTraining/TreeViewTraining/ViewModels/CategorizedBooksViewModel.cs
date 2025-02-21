using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewTraining.ViewModels;

public partial class CategorizedBooksViewModel : ObservableObject
{
    [ObservableProperty]
    private string category;


    [ObservableProperty]
    ObservableCollection<CategorizedBooksViewModel> books;  

}
