using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Training;

public class CurrencyViewViewModel : BaseViewModel
{


	private decimal _CurrencyValue;
	public decimal CurrencyValue
	{
		get => _CurrencyValue;
		set
		{
			_CurrencyValue = value;
			this.RaisePropertyChanged();
			this.RaisePropertyChanged(nameof(HasNonZeroValue));
		}
	}


	public bool HasNonZeroValue => CurrencyValue != 0.0m;




}
