using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Frevent.Model.Models;
using Frevent.Service;
using Frevent.Web.ViewModels;

namespace Frevent.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventService eventService;
        private readonly IPlaceService placeService;

        public HomeController(IEventService eventService, IPlaceService placeService)
        {
            this.eventService = eventService;
            this.placeService = placeService;
        }

        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<EventViewModel> viewModelEvents;
            IEnumerable<Event> events;

            events = eventService.GetEvents().ToList();

            viewModelEvents = Mapper.Map<IEnumerable<Event>, IEnumerable<EventViewModel>>(events);
            return View(viewModelEvents);
        }

        [HttpPost]
        public ActionResult Create(EventFormViewModel newEvent)
        {            
            var anEvent = Mapper.Map<EventFormViewModel, Event>(newEvent);

            eventService.CreateEvent(anEvent);
            eventService.SaveEvent();

            return RedirectToAction("Index");
        }
    }
}