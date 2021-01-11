using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_Login_System
{
    class User
    {
        private string username;
        public string fullusername;
        private string password;
        public bool loggedIn = false;

        public User(string un, string fu, string pw)// Constructor
        {
            username = un;
            password = pw;
            fullusername = fu;
        }

        public bool CheckLogin(string un, string pw)
        {
            if (un == username && pw == password)
            {
                loggedIn = true;
                return true;
            }
            else
            {
                return false;

            }
        }

        public void LogOut()
        {
            loggedIn = false;
        }
        public void ChangePassword(string newPassword)
        {
            if (loggedIn == true)
            {
                Console.WriteLine("SUCCESS");
                password = newPassword;
                
            }
        }
    }
}







