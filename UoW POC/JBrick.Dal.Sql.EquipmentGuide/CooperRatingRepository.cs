using JBrick.Contracts.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace JBrick.Dal.Sql.MockEquipmentGuide
{
   public class CooperRatingRepository : ICooperRatingRepository
   {
      public CooperRatingRepository(IRepositoryContextProvider<IDbConnection> repositoryContextProvider, ILogger logger)
      {
         if (repositoryContextProvider == null)
         {
            throw new ArgumentNullException("repositoryContextProvider");
         }
      }

      #region Modifiers

      public CooperRatingDto Insert(CooperRatingDto dto)
      {
         dto.Id = MockDb.CooperRatings.Count > 0 ? MockDb.CooperRatings.Max(c => c.Id) + 1 : 1;

         var newItem = new MockCooperRatingDataTable
         {
            Id = dto.Id,
            BndFtKips = dto.BndFtKips,
            BridgeSpanFeet = dto.BridgeSpanFeet,
            CarClass = dto.CarClass,
            CarInitial = dto.CarInitial,
            CooperRatingEBnd = dto.CooperRatingEBnd,
            CooperRatingEFloor = dto.CooperRatingEFloor,
            CooperRatingEShear = dto.CooperRatingEShear,
            FloorReactKips = dto.FloorReactKips,
            ShearKips = dto.ShearKips
         };

         MockDb.CooperRatings.Add(newItem);

         return dto;
      }

      public CooperRatingDto Update(CooperRatingDto dto)
      {
         var data = (from c in MockDb.CooperRatings
                     where c.Id == dto.Id
                     select c).FirstOrDefault();

         if (data == null)
         {
            throw new InvalidOperationException("Not Found");
         }

         data.BndFtKips = dto.BndFtKips;
         data.BridgeSpanFeet = dto.BridgeSpanFeet;
         data.CarClass = dto.CarClass;
         data.CarInitial = dto.CarInitial;
         data.CooperRatingEBnd = dto.CooperRatingEBnd;
         data.CooperRatingEFloor = dto.CooperRatingEFloor;
         data.CooperRatingEShear = dto.CooperRatingEShear;
         data.FloorReactKips = dto.FloorReactKips;
         data.ShearKips = dto.ShearKips;

         return dto;
      }

      public void Delete(int id)
      {
         MockDb.CooperRatings.RemoveAll(c => c.Id == id);
      }

      #endregion

      #region Retrievers

      public CooperRatingDto Fetch(int id)
      {
         var result = (from c in MockDb.CooperRatings
                       where c.Id == id
                       select new CooperRatingDto()
                       {
                          Id = c.Id,
                          BndFtKips = c.BndFtKips,
                          BridgeSpanFeet = c.BridgeSpanFeet,
                          CarClass = c.CarClass,
                          CarInitial = c.CarInitial,
                          CooperRatingEBnd = c.CooperRatingEBnd,
                          CooperRatingEFloor = c.CooperRatingEFloor,
                          CooperRatingEShear = c.CooperRatingEShear,
                          FloorReactKips = c.FloorReactKips,
                          ShearKips = c.ShearKips
                       }).FirstOrDefault();

         return result;
      }

      public IEnumerable<CooperRatingDto> FetchAll()
      {
         var result = from c in MockDb.CooperRatings
                      select new CooperRatingDto()
                      {
                         Id = c.Id,
                         BndFtKips = c.BndFtKips,
                         BridgeSpanFeet = c.BridgeSpanFeet,
                         CarClass = c.CarClass,
                         CarInitial = c.CarInitial,
                         CooperRatingEBnd = c.CooperRatingEBnd,
                         CooperRatingEFloor = c.CooperRatingEFloor,
                         CooperRatingEShear = c.CooperRatingEShear,
                         FloorReactKips = c.FloorReactKips,
                         ShearKips = c.ShearKips
                      };

         return result;
      }
      #endregion

   }
}