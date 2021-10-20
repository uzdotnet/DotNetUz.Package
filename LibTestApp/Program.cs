using System;
using System.Linq;
using DotNetUz.Tools;
using DotNetUz.Json;
using System.Net.Http;
using System.Collections;
using System.Collections.Generic;

namespace LibTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            Course pb = client.GetJson<Course>("https://zamineducation.herokuapp.com/api/CourseFor/GetAllCourseFor");

            Person p = new Person() { CourseForId = 1, CourseForValue = "ferfge" };
            Console.WriteLine(p.AsJson());

            //var data = ((IEnumerable)pb.Data).Cast<object>();
            //Console.WriteLine(data.Count());
       }
    }
    class Course
    {
        public string Response { get; set; }
        public dynamic Data { get; set; }
        public string Token { get; set; }
    }
    class Person
    {
        public int CourseForId { get; set; }
        public string CourseForValue { get; set; }
    }

}
