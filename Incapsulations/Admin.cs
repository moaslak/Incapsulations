using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulations
{
    public class Admin : NormalUser
    {
        private string password { get; set; }
        public Admin(int Id, string Name, bool isAdmin) : base(Id, Name, isAdmin)
        {
            this.isAdmin = true;
        }

        internal protected override void SetPassword(string Password)
        {
            this.password = Password;
        } 

        // ToString() kan ikke override's, da denne bliver sealed i NormalUser
        /*
        public override string ToString()
        {
            return base.ToString() + " and is admin";
        }*/
    }
}
