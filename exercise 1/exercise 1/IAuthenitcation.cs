using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    public interface IAuthenitcation
    {
        public bool Login(string Modleusername, string Modlepassword);
        public bool checkacess(string modleUsername);
        public int LastId();
        public bool Register(string Email,string password, string Username);
    }
}
