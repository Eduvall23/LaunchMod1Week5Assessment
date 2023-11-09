using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchMod1Week5Assessment
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        private string Password { get; set; }
        public bool IsPasswordCreated { get; private set; }
        public bool IsLoggedIn { get; set; }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
            IsLoggedIn = false;
        }
// i changed the conditions for the if statemnt becuase it uses the -
//  - varible i made that cant be true unless you create a password which you cant do wihtout a name and email so it works 
        public bool IsSetupComplete()
        {
            if (IsPasswordCreated) 
            {
               return true;
            }
            else
            {
                return false;
            }
        }
        // i added a way to check if the password was created and got rid of a second if statemnt because it felt unesscary 
        public void CreatePassword(string email, string password)
        {
            if (email==Email && password != null) 
            {
                Password = password; 
                IsPasswordCreated = true;
            }
            
        }
        // i changed this just because it made sense to have both email and password and its reutrn didnt make sense for me 
        public string LogIn(string email, string password)
        {
            if (email == Email && password == Password)
            {
                IsLoggedIn = true;
                return $"Welcome back {Name}";
            }
            return "Wrong email and/or password";
        }

        public void LogOut()
        {
            IsLoggedIn = false;
        }
    }
}
