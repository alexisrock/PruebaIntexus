﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Dto.Request;
using Domain.Dto.Response;
using Domain.Entities;

namespace Application.Profiles
{
    [ExcludeFromCodeCoverage]
    public class TareaProfile : Profile
    {


        public TareaProfile() {

            CreateMap<Tarea, TareaRequest>()
                 .ReverseMap();

            CreateMap<Tarea, TareaResponse>()
                .ReverseMap();

        }
    }
}
