﻿using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICourseService
    {
        //CourseViewModel GetCourses();
        IEnumerable<CourseViewModel> GetCourses();

        void Create(CourseViewModel courseViewModel);
    }
}
