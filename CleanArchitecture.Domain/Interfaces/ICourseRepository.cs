using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface ICourseRepository
    {
        //IEnumerable<Course> GetCourses();
        IQueryable<Course> GetCourses();
        void Add(Course course);
    }
}
