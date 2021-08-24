using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class Users
    {
        public int IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public char h { get; set; }
        public override string ToString()
        {
            return $"IdUser: {IdUser}\nUsername: {Username}\nPassword: {Password}\nEmail: {Email}\nPhone: {Phone}\nBirthDate: {BirthDate}\nH: {h}";
        }
    }
}
