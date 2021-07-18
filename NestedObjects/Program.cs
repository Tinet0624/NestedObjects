using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor currInstructor = new Instructor()
            {
                FullName = "Joe Ortiz",
                Email = "joe.ortiz@cptc.edu"
            };

            Student student1 = new Student()
            {
                FirstName = "Jim",
                LastName = "Halpert"
            };

            Student student2 = new Student()
            {
                FirstName = "Alexandra",
                LastName = "Haley"
            };

            Student student3 = new Student()
            {
                FirstName = "James",
                LastName = "Haley"
            };

            Course testCourse = new Course()
            {
                Title = "cpw212 - Advanced .NET",
                Description = "More .NET",
                Credits = 5,
                CourseInstructor = currInstructor, // uses the refrenced instructor
                Roster = new List<Student>()
            };
            // adding students to course
            testCourse.Roster.Add(student1);
            testCourse.Roster.Add(student2);
            testCourse.Roster.Add(student3);

            Console.WriteLine(testCourse.Title);
            Console.WriteLine($"Is taught by {testCourse.CourseInstructor.FullName}");
            Console.WriteLine("Currently enrolled students: ");
            foreach (Student student in testCourse.Roster)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.ReadKey();
        }
    }
}
