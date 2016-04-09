using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Frevent.Model.Models;
using Frevent.Web.ViewModels;

namespace Frevent.Web.Mappings
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<EventFormViewModel, Event>()
                .ForMember(e => e.Name, map => map.MapFrom(vm => vm.EventName))
                .ForMember(e => e.Start, map => map.MapFrom(vm => vm.EventStart))
                .ForMember(e => e.End, map => map.MapFrom(vm => vm.EventEnd));
        }
    }
}