using JBrick.Contracts.Logging;
using JBrick.Dal.EF.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Dal.EF.EquipmentGuide
{
    public class CooperRatingRepository : ICooperRatingRepository
    {
        private MockDBContext _dbContext = null;
        private static int _globalIdCounter = 0;

        public CooperRatingRepository(IRepositoryContextProvider<DbContext> dbContextProvider, ILogger logger)
        {
            if (dbContextProvider == null)
            {
                throw new ArgumentNullException("dbContextProvider");
            }

            _dbContext = dbContextProvider.GetRepositoryContext(EFModelTypes.MockEquipmentGuide.ToString()).RepositoryContext as MockDBContext;

        }

        public IEnumerable<CooperRatingDto> FetchAll()
        {
            var searchResults = new List<CooperRatingDto>();

            var crList = _dbContext.CooperRatings;

            foreach (var cr in crList)
            {
                searchResults.Add(new CooperRatingDto
                {
                    BndFtKips = cr.BndFtKips,
                    BridgeSpanFeet = cr.BridgeSpanFeet,
                    CarClass = cr.CarClass,
                    CarInitial = cr.CarInitial,
                    CooperRatingEBnd = cr.CooperRatingEBnd,
                    CooperRatingEFloor = cr.CooperRatingEFloor,
                    CooperRatingEShear = cr.CooperRatingEShear,
                    FloorReactKips = cr.FloorReactKips,
                    Id = cr.Id,
                    ShearKips = cr.ShearKips
                });
            }

            return searchResults;
        }

        public CooperRatingDto Fetch(int id)
        {
            var cr = _dbContext.CooperRatings.FirstOrDefault(x => x.Id == id);

            if (cr == null)
            {
                throw new KeyNotFoundException("Could not find Cooper Rating id " + id.ToString());
            }

            return new CooperRatingDto
            {
                BndFtKips = cr.BndFtKips,
                BridgeSpanFeet = cr.BridgeSpanFeet,
                CarClass = cr.CarClass,
                CarInitial = cr.CarInitial,
                CooperRatingEBnd = cr.CooperRatingEBnd,
                CooperRatingEFloor = cr.CooperRatingEFloor,
                CooperRatingEShear = cr.CooperRatingEShear,
                FloorReactKips = cr.FloorReactKips,
                Id = cr.Id,
                ShearKips = cr.ShearKips
            };
        }

        public CooperRatingDto Insert(CooperRatingDto item)
        {
            _globalIdCounter += 1;

            var newCooperRating = new MockEntityCooperRating
            {
                BndFtKips = item.BndFtKips,
                BridgeSpanFeet = item.BridgeSpanFeet,
                CarClass = item.CarClass,
                CarInitial = item.CarInitial,
                CooperRatingEBnd = item.CooperRatingEBnd,
                CooperRatingEFloor = item.CooperRatingEFloor,
                CooperRatingEShear = item.CooperRatingEShear,
                FloorReactKips = item.FloorReactKips,
                Id = _globalIdCounter,
                ShearKips = item.ShearKips
            };

            _dbContext.CooperRatings.Add(newCooperRating);
            _dbContext.SaveChanges();

            item.Id = newCooperRating.Id;
            return item;
        }

        public CooperRatingDto Update(CooperRatingDto item)
        {
            var cr = _dbContext.CooperRatings.FirstOrDefault(x => x.Id == item.Id);

            if (cr == null)
            {
                throw new KeyNotFoundException("Could not find Cooper Rating id " + item.Id.ToString());
            }

            cr.BndFtKips = item.BndFtKips;
            cr.BridgeSpanFeet = item.BridgeSpanFeet;
            cr.CarClass = item.CarClass;
            cr.CarInitial = item.CarInitial;
            cr.CooperRatingEBnd = item.CooperRatingEBnd;
            cr.CooperRatingEFloor = item.CooperRatingEFloor;
            cr.CooperRatingEShear = item.CooperRatingEShear;
            cr.FloorReactKips = item.FloorReactKips;
            cr.ShearKips = item.ShearKips;

            _dbContext.SaveChanges();

            return item;
        }

        public void Delete(int id)
        {
            var cr = _dbContext.CooperRatings.FirstOrDefault(x => x.Id == id);

            if (cr == null)
            {
                throw new KeyNotFoundException("Could not find Cooper Rating id " + id.ToString());
            }

            _dbContext.CooperRatings.Remove(cr);
            _dbContext.SaveChanges();
        }
    }
}
