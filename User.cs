using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoLibrary
{
    public abstract class User : IInformation
    {
        //the event, that starts by entering name
        protected internal event UserInfoStateHundler EnteredName;
        //the event, that starts by entering surname
        protected internal event UserInfoStateHundler EnteredSurname;
        //the event, that starts by entering sex
        protected internal event UserInfoStateHundler EnteredSex;
        //the event, that starts by entering age
        protected internal event UserInfoStateHundler EnteredAge;
        //the event, that starts by writing the midlle age of all users
        protected internal event UserInfoStateHundler WriteTheMidAge;
        //the event, that starts by writing the eldest user
        protected internal event UserInfoStateHundler WriteTheElder;
        //the event, that starts by writing the popular female name
        protected internal event UserInfoStateHundler WritePopFName;
        //the event, that starts by writing all homonym
        protected internal event UserInfoStateHundler WriteAllHomonym;

        protected string _name; //for save name
        protected string _surname;//for save surname
        protected string _sex;//for save sex
        protected int _age;//for save age
        

        public User(string name, string surname, string sex, int age)
        {
            _name = name;
            _surname = surname;
            _sex = sex;
            _age = age;
        }
        //calling events
        private void CallEvent(UserEventArgs e, UserInfoStateHundler handler)
        {
            if (handler != null && e != null)
                handler(this, e);
        }
        //calling individual events
        //every event have virtual method
        protected virtual void OnEnteredName(UserEventArgs e)
        {
            CallEvent(e, EnteredName);
        }
        protected virtual void OnEnteredSurname(UserEventArgs e)
        {
            CallEvent(e, EnteredSurname);
        }
        protected virtual void OnEnteredSex(UserEventArgs e)
        {
            CallEvent(e, EnteredSex);
        }
        protected virtual void OnEnteredAge(UserEventArgs e)
        {
            CallEvent(e, EnteredAge);
        }
        protected virtual void OnWriteTheMidAge(UserEventArgs e)
        {
            CallEvent(e, WriteTheMidAge);
        }
        protected virtual void OnWriteTheElder(UserEventArgs e)
        {
            CallEvent(e, WriteTheElder);
        }
        protected virtual void OnWritePopFName(UserEventArgs e)
        {
            CallEvent(e, WritePopFName);
        }
        protected virtual void OnWriteAllHomonym(UserEventArgs e)
        {
            CallEvent(e, WriteAllHomonym);
        }

        //public virtual void EnterName()
        //{

        //}







    }
}
