using System;
using System.Collections.Generic;

namespace WPFTest
{
    public partial class UsersLogin
    {
        public UsersLogin(string password, string name)
        {
            Password = password;
            Name = name;
        }

        public int Id { get; set; }
        public string Password { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
