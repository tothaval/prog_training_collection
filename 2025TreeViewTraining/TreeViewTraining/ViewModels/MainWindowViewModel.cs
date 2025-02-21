using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewTraining.Services;

namespace TreeViewTraining.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{

    readonly IBookService _bookService;


    [ObservableProperty]
    ObservableCollection<CategorizedBooksViewModel> books = new ObservableCollection<CategorizedBooksViewModel>();


    public MainWindowViewModel(IBookService bookService)
    {
        _bookService = bookService;

        var booksToAdd = this._bookService.GetBooks()
            .GroupBy(b => b.Category)
            .Select(b => new CategorizedBooksViewModel()
            {
                Category = b.Key,
                Books = new ObservableCollection<CategorizedBooksViewModel>(
                            b.Select(b1 => new CategorizedBooksViewModel()
                            {
                                Category = $"{b1.Title} - {b1.Author}"
                            }
                        )
                )
            });

        foreach (var book in booksToAdd)
            this.Books.Add(book);


    }
}