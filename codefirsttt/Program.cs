using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace codefirsttt
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Ani { get; set; }
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
    }

   

    public class Book : DbContext
    {
        public DbSet<Person> GetPersons { get; set; }
        

        public Book()
            : base("name=DefaultConnection")
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
