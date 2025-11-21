using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectManagement;

namespace userManagement
{
    public class User
    {
        public string Username { get; set; } //the username of the user
        public string Password { get; set; } //the password of the user
        public List<Project> Projects { get; set; } //project list of the user

        //sets the username and password and initialized an empty project list
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Projects = new List<Project>();
        }

        //method to check if the entered username and password have a matched
        public bool Login(string inputUsername, string inputPassword)
        {
            return Username == inputUsername && Password == inputPassword;
        }
    }
}
