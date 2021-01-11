using System;

namespace Assignment_1_Login_System
{
    class Program
    {
        static void Main(string[] args)
        {
            User bob = new User("Bobby", "Bob Ross", "bob123");
            Console.WriteLine("User logged in:" + bob.loggedIn);

            Console.Write(bob.CheckLogin("Adam", "adam123"));
            Console.Write(bob.CheckLogin("Bobby", "adam123"));
            Console.Write(bob.CheckLogin("Bobby", "bob123"));

            Console.WriteLine("User logged in:" + bob.loggedIn);

            Console.WriteLine(bob.fullusername);
            bob.ChangePassword("brown123");
            bob.LogOut();
            Console.WriteLine(bob.CheckLogin("Bobby", "brown123"));
        }
    }
}
