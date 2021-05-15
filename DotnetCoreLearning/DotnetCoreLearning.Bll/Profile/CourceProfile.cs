using System;
using System.Collections.Generic;
using System.Text;
using DotnetCoreLearning.Dal.Models;
using DotnetCoreLearning.Mdl.Model;

namespace DotnetCoreLearning.Bll.Profile
{
    public class CourceProfile: AutoMapper.Profile
    {
        public CourceProfile()
        {
            CreateMap<Cource, CourceStruct>()
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(model => model.StartDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(model => model.EndDate.ToString("yyyy-MM-dd")));
        }
    }
}
