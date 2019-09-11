using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;


        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            //var createCourseCommand = new CreateCourseCommand(
            //    courseViewModel.Name,
            //    courseViewModel.Description,
            //    courseViewModel.ImageURL                
            //    );
            //_bus.SendCommand(createCourseCommand);

            _bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseViewModel));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            //return new CourseViewModel()
            //{
            //    Courses = _courseRepository.GetCourses()
            //};
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
