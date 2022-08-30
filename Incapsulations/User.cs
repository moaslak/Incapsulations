using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Incapsulations
{
    public abstract class User
    {
        
        protected int Id { get; set; }
        protected string Name { get; set; }

        public User(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

    static class DatabaseCon
    {
        static string DatabaseServer = "docker.data.techcollege.dk,20001";
        static string databasePassword = "hest";
    }
}
