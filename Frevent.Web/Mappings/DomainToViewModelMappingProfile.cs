﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Frevent.Model.Models;
using Frevent.Web.ViewModels;

namespace Frevent.Web.Mappings
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Event, EventViewModel>();
            Mapper.CreateMap<Place, PlaceViewModel>();
        }
    }
}