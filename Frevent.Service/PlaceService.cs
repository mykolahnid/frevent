using System.Collections.Generic;
using Frevent.Data.Infrastructure;
using Frevent.Data.Repositories;
using Frevent.Model.Models;

namespace Frevent.Service
{
    public interface IPlaceService
    {
        IEnumerable<Place> GetPlaces();
        Place GetPlace(int id);
        void CreatePlace(Place gadget);
        void SavePlace();
    }

    public class PlaceService : IPlaceService
    {
        private readonly IPlaceRepository placeRepository;
        private readonly IUnitOfWork unitOfWork;

        public PlaceService(IPlaceRepository placeRepository, IUnitOfWork unitOfWork)
        {
            this.placeRepository = placeRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IPlaceService members

        public IEnumerable<Place> GetPlaces()
        {
            var places = placeRepository.GetAll();
            return places;
        }

        public Place GetPlace(int id)
        {
            var place = placeRepository.GetById(id);
            return place;
        }

        public void CreatePlace(Place place)
        {
            placeRepository.Add(place);
        }

        public void SavePlace()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}