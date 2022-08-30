using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulations
{
    public class NormalUser : User
    {
        protected bool isAdmin { get; set; }

        public string password { get; protected set; }

        public NormalUser(int Id, string Name, bool IsAdmin) : base(Id, Name)
        {
            this.isAdmin = false;
        }
        public sealed override string ToString()
        {
            return "userID: " + Id + ", username: " + Name + ", is admin : " + isAdmin;
        }

        internal protected virtual void SetPassword(string password)
        {
            this.password = password;
        }
    }
}
