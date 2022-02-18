using System;

namespace ClassesAndRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            var pluralsightCourse = new Course();
            pluralsightCourse.Name = "name";
            pluralsightCourse.Author = "me";

            var record = new CourseRecord("Records course", "me");
        }
    }

    class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }

    public record CourseRecord(string Name, string Author);
}
