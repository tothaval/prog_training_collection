using DelegateTraining_ClubMemberShipApplication.FieldValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTraining_ClubMemberShipApplication.Views
{
    public interface IView
    {
        void RunView();

        IFieldValidator FieldValidator { get; }
    }
}
