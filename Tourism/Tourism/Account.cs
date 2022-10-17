using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism
{
    internal class Account
    {
        private string name;
        private string surname;
        private int age;
        private string email;
        private string password;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name cannot be empty."); 
                name = value;
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                    surname = "";
                else
                    surname = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16) throw new Exception("You should be more than 16 y.o.");
                else age = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Email cannot be empty."); 
                else 
                    email = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Password cannot be empty."); 
                else 
                    password = value;
            }
        }

        public string FullName() => name + surname;
    }
}
