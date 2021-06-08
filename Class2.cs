
// CURRENT CASE

using System;

using System.Text;
namespace Customer
{
    class User
    {
        private string address;
        private string name;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            // set accessor will invoke
            u.Name = "Franz Maaba";
            // set accessor will invoke
            u.Address = "Laguna";
            // get accessor will invoke
            Console.WriteLine("Name: " + u.Name);
            // get accessor will invoke
            Console.WriteLine("Address: " + u.Address);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}


// PREVIOUS CASE
{
    class Program : Customer
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.FirstName = "Franz";
            p.LastName = "Maaba";
            p.FullName();
            Console.ReadLine();

        }
        public override void FullName()
        {
            Console.WriteLine("Full Name:" + FirstName + " " + LastName);
        }
    }
}