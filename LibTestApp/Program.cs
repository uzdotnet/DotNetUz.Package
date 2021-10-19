using System;
using System.Linq;
using DotNetUz.Tools;
using DotNetUz.Json;

namespace LibTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Muhammadkarim",
                DateOfBirth = DateTime.Now
            };
            string json = person.AsJson();
            var ob = json.JsonAs<Person>();
            Console.WriteLine(ob.Name);
        }
    }
    class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
