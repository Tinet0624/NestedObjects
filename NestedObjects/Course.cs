using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    public class Course
    {
        /// <summary>
        /// Full title of the course
        /// ex: Advanced .NET programming
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// the official description of the course
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The number of collge credits awarded for passing the course
        /// </summary>
        public byte Credits { get; set; }
        /// <summary>
        /// The Instructor that teaches the course
        /// Uses the class Instructor
        /// </summary>
        public Instructor CourseInstructor { get; set; }
        /// <summary>
        /// All students currently enrolled in the class
        /// Collections of objects
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}
