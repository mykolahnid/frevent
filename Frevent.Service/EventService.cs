using System.Collections.Generic;
using Frevent.Data.Infrastructure;
using Frevent.Data.Repositories;
using Frevent.Model.Models;

namespace Frevent.Service
{
    public interface IEventService
    {
        IEnumerable<Event> GetEvents();
        Event GetEvent(int id);
        void CreateEvent(Event gadget);
        void SaveEvent();
    }

    public class EventService : IEventService
    {
        private readonly IEventRepository eventRepository;
        private readonly IUnitOfWork unitOfWork;

        public EventService(IEventRepository eventRepository, IUnitOfWork unitOfWork)
        {
            this.eventRepository = eventRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IEventService members

        public IEnumerable<Event> GetEvents()
        {
            var events = eventRepository.GetAll();
            return events;
        }

        public Event GetEvent(int id)
        {
            var anEvent = eventRepository.GetById(id);
            return anEvent;
        }

        public void CreateEvent(Event anEvent)
        {
            eventRepository.Add(anEvent);
        }

        public void SaveEvent()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}