using AutoMapper;
using CarService.BusinessObjects;
using CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.Configuration;
        }
    }
}
