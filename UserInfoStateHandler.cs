using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoLibrary
{
    //delegate UserInfoStateHundler would be used for creating events
    public delegate void UserInfoStateHundler(object sender, UserEventArgs e);

    public class UserEventArgs
    {
        //name
        public string Name { get; set; }
        //surname
        public string Surname { get; set; }
        //sex
        public string Sex { get; set; }
        //age
        public int Age { get; set; }

        public UserEventArgs(string _name, string _surname, string _sex, int _age)
        {
            Name = _name;
            Surname = _surname;
            Sex = _sex;
            Age = _age;
        }
    }
}
