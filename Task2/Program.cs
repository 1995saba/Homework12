using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User { Id = 123, Login = "admin", Password = "123qwerty" };
            Type userType = typeof(User);

            foreach(var property in userType.GetProperties())
            {
                Console.WriteLine(property.ToString() + "  =  " +property.GetValue(user));
            }
            Console.ReadLine();
        }
    }
}
