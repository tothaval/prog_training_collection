using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPFBasics;

namespace WPF_MVVM_Training;

public class MainWindowViewModel : BaseViewModel
{

    public MainWindowViewModel()
    {
		this.ClearCommand = new DelegateCommand(
			(o) => !String.IsNullOrEmpty(_FirstName) && !String.IsNullOrEmpty(_LastName),
			(o) => { this.FirstName = ""; this.LastName = ""; }
			);

        FirstName = "Dave";
        LastName = "Dev";

    }

	public DelegateCommand ClearCommand { get; set; }


    private string _FirstName;
	public string FirstName
	{
		get =>_FirstName;
		set
		{
			_FirstName = value;

			this.RaisePropertyChanged();
            this.RaisePropertyChanged(nameof(FullName));
			this.ClearCommand.RaiseCanExecuteChanged();
		}
	}


	private string _LastName;
	public string LastName
	{
		get => _LastName;
		set
		{
			_LastName = value;

            this.RaisePropertyChanged();
            this.RaisePropertyChanged(nameof(FullName));
			this.ClearCommand.RaiseCanExecuteChanged();
        }
	}


    public string FullName => $"{FirstName} {LastName}";


}
