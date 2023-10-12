using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP.Models
{
    public class User
    {
        public User(string _UserName, string _Password)
        {
            UserName = _UserName;
            Password = _Password;
        }

        string _password;

        public string UserName { get; set; }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Password en az dört karakter olmalıdır.");
                }
                else
                {
                    _password = value;
                }
            }
        }
    }
}
