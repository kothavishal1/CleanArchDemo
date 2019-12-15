using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models
{
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDesc { get; set; }
        public string ImageUrl { get; set; }
    }
}
