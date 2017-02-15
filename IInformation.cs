using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoLibrary
{
    public interface IInformation
    {
        //this interface contains 4 methods

        //entering name
        void EnterName(string user);
        //entering surname
        void EnterSurname(string user);
        //entering sex
        void EnterSex(string user);
        //entering age
        void EnterAge(int user);
    }
}
