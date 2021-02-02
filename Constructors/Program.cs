using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirsName = "Engin", LastName = "Demiroğ", City = "Ankkara" };

            Customer customer3 = new Customer();
            customer3.Id = 1;


            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirsName);


        }

        static void Method(int id, string firstName, string lastName, string city)
        {

        }
    }

    class Customer
    {
        //default constructor

        public Customer()
        {

        }

        public Customer(int id,string firstName , string lastName , string city)
        {
            FirsName = firstName;
            LastName = lastName;
            Id = id;
            City = city;
        }
        public int Id { get; set; }
        public String FirsName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
