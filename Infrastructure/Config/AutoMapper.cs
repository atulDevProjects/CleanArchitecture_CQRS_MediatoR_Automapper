using Application.EmployeeDetails.Commands;
using Application.EmployeeDetails.Queries;
using AutoMapper;
using Domain.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Employee, EmployeeDTO>();
            CreateMap<AddEmployeeDetails, Employee>();
        }
    }
}
