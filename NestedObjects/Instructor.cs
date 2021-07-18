using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// The name and email of the Instructor for the courses
    /// </summary>
    class Instructor
    {
        /// <summary>
        /// Legal Full name first and last
        /// ex: Jane Doe
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Company email address
        /// ex: jane.doe@cptc.edu
        /// </summary>
        public string Email { get; set; }
    }
}