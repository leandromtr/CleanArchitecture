﻿using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;
using System;
using System.Collections.Generic;
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

        public IEnumerable<Course> GetCourses()
        {
            return _conn.Courses;
        }
    }
}