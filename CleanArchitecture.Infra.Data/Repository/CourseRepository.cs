using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private CleanArchitectureDBContext _conn;

        public CourseRepository(CleanArchitectureDBContext conn)
        {
            _conn = conn;
        }

        public void Add(Course course)
        {
            _conn.Courses.Add(course);
            _conn.SaveChanges();
        }

        public IQueryable<Course> GetCourses()
        {
            return _conn.Courses;
        }
    }
}
