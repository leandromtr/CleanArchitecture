using AutoMapper;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.AutoMapper
{
    class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(e => new CreateCourseCommand(e.Name, e.Description, e.ImageURL));
        }
    }
}
