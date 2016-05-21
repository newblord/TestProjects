using JBrick.BL.Core;
using JBrick.Contracts.Business;
using JBrick.Dal;
using System.Collections.Generic;
using System.Linq;
using System;

namespace JBrick.BL.EquipmentGuide
{
   public class CooperRatingBusinessService : BusinessServiceBase, ICooperRatingBusinessService
   {

        public string GetUnitOfWorkProviderType()
        {
            using (var uow = this.UnitOfWorkFactory.GetUnitOfWorkWithoutTransaction())
            {
                return uow.GetType().Namespace;
            }
        }

        #region Constructors

        public CooperRatingBusinessService(IUnitOfWorkFactory unitOfWorkFactory)
          : base(unitOfWorkFactory)
      {

      }

      #endregion

      #region Modifiers

      public ICooperRatingModel CreateCooperRating(ICooperRatingModel data)
      {
         using (var uow = this.UnitOfWorkFactory.GetUnitOfWork())
         {
            var rep = uow.GetRepository<ICooperRatingRepository>();
            var result = rep.Insert(MarshallCooperRatingDto(data));

            uow.CommitChanges();

            return MarshallCooperRatingModel(result);
         }
      }

      public ICooperRatingModel UpdateCooperRating(ICooperRatingModel data)
      {
         using (var uow = this.UnitOfWorkFactory.GetUnitOfWork())
         {
            var rep = uow.GetRepository<ICooperRatingRepository>();
            var result = new CooperRatingDto();

            result = rep.Update(MarshallCooperRatingDto(data));

            uow.CommitChanges();

            return MarshallCooperRatingModel(result);
         }
      }

      public void DeleteCooperRating(int id)
      {
         using (var uow = this.UnitOfWorkFactory.GetUnitOfWork())
         {
            var rep = uow.GetRepository<ICooperRatingRepository>();
            rep.Delete(id);

            uow.CommitChanges();
         }
      }

      #endregion

      #region Retrievers

      public ICooperRatingModel FetchCooperRating(int id)
      {
         using (var uow = this.UnitOfWorkFactory.GetUnitOfWork())
         {
            var rep = uow.GetRepository<ICooperRatingRepository>();
            var dto = rep.Fetch(id);

            uow.CommitChanges();

            return MarshallCooperRatingModel(dto);
         }
      }

      public IEnumerable<ICooperRatingModel> FetchAllCooperRating()
      {
         using (var uow = this.UnitOfWorkFactory.GetUnitOfWork())
         {
            var results = new List<ICooperRatingModel>();
            var rep = uow.GetRepository<ICooperRatingRepository>();
            var items = rep.FetchAll();

            foreach (var dto in items)
            {
               results.Add(MarshallCooperRatingModel(dto));
            }

            uow.CommitChanges();

            return results;
         }
      }

      #endregion

      #region Marshalling

      private CooperRatingDto MarshallCooperRatingDto(ICooperRatingModel model)
      {
         var dto = new CooperRatingDto();

         dto.Id = model.Id;
         dto.BndFtKips = model.BndFtKips;
         dto.BridgeSpanFeet = model.BridgeSpanFeet;
         dto.CarClass = model.CarClass;
         dto.CarInitial = model.CarInitial;
         dto.CooperRatingEBnd = model.CooperRatingEBnd;
         dto.CooperRatingEFloor = model.CooperRatingEFloor;
         dto.CooperRatingEShear = model.CooperRatingEShear;
         dto.FloorReactKips = model.FloorReactKips;
         dto.ShearKips = model.ShearKips;

         return dto;
      }

      private CooperRatingModel MarshallCooperRatingModel(CooperRatingDto dto)
      {
         var model = new CooperRatingModel();

         model.Id = dto.Id;
         model.BndFtKips = dto.BndFtKips;
         model.BridgeSpanFeet = dto.BridgeSpanFeet;
         model.CarClass = dto.CarClass;
         model.CarInitial = dto.CarInitial;
         model.CooperRatingEBnd = dto.CooperRatingEBnd;
         model.CooperRatingEFloor = dto.CooperRatingEFloor;
         model.CooperRatingEShear = dto.CooperRatingEShear;
         model.FloorReactKips = dto.FloorReactKips;
         model.ShearKips = dto.ShearKips;

         return model;
      }

        #endregion

    }
}