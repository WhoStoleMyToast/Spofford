using AutoMapper;
using Spofford.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spofford.WebApi
{
    public static class AutoMapperDomainConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new EntryProfile());
                cfg.AddProfile(new TeamProfile());
            });
        }
    }

    public class EntryProfile : Profile
    {
        protected override void Configure()
        {
            AutoMapper.Mapper.CreateMap<Entry, EntryCreateViewModel>();
            AutoMapper.Mapper.CreateMap<EntryCreateViewModel, Entry>();
        }
    }

    public class TeamProfile : Profile
    {
        protected override void Configure()
        {
            AutoMapper.Mapper.CreateMap<Team, TeamCreateViewModel>();
            AutoMapper.Mapper.CreateMap<TeamCreateViewModel, Team>();
        }
    }
}