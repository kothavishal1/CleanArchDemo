using CleanArch.Data.Context;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Data.Repository
{
    public class CourseRepository  : ICourseRepo
    {
        private UniversityDBContext _univContext;
        public CourseRepository(UniversityDBContext utx)
        {
            _univContext = utx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _univContext.Courses;
        }
    }
}
