using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncSprint
{
    internal class EmailCheck
    {
        public static string CheckValidEmail(string email)
        {
            Predicate<string> s = s => email.Substring(email.IndexOf('@')) == "@northcoders.co.uk";
            Predicate<string> s2 = s => email.Substring(0, email.IndexOf('@')).Length >= 5;
            return s(email) && s2(email) ? "Email domain and user valid, please continue" : "Email domain and user name invalid, please check your input";
        }
    }
}
