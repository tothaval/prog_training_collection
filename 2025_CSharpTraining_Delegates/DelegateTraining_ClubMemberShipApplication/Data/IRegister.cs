using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTraining_ClubMemberShipApplication.Data
{
    public interface IRegister
    {

        bool Register(string[] fields);
        bool EmailExists(string emailAddress);

    }
}
