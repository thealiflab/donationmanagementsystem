using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class user_class
    {
        private string name;
        private string email;
        private long phonenumber;
        private string password;
        private static int id;
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public long PhoneNumber { get { return this.phonenumber; } set { this.phonenumber = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }

    }
}
