using System;

namespace Incapsulations
{
    class program
    {
        public static void Main(string[] args)
        {
            Admin admin = new Admin(1, "sdf", true);
            admin.SetPassword("hest");
            NormalUser normalUser = new NormalUser(2, "asdf", true);
            normalUser.SetPassword("her");
            Console.WriteLine(admin.ToString());
            Console.WriteLine(normalUser.ToString());
            Console.ReadKey();
        }
    }
}