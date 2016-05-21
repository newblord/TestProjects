using JBrick.Contracts.Logging;
using JBrick.Dal.Sql.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace JBrick.Dal.Sql.EquipmentGuideMock
{
    public class CooperRatingRepository : ICooperRatingRepository
    {
        IDbConnection _equipmentGuideConnection;

        public CooperRatingRepository(IRepositoryContextProvider<IDbConnection> repositoryContextProvider, ILogger logger)
        {
            if (repositoryContextProvider == null)
            {
                throw new ArgumentNullException("repositoryContextProvider");
            }

            //_equipmentGuideConnection = repositoryContextProvider.GetRepositoryContext(SqlConnectionKey.MockDb.ToString()).RepositoryContext;
        }

        #region Modifiers

        public CooperRatingDto Insert(CooperRatingDto dto)
        {
            /// Instead of using an actual SQL connection and ADO.NET use the MockDb
            ////using (var cm = _equipmentGuideConnection.CreateCommand())
            ////{
            ////    cm.CommandType = System.Data.CommandType.StoredProcedure;
            ////    cm.CommandText = "CooperRatingInsertStoredProcName";
            ////    cm.Parameters.AddWithValue("@Id", dto.Id);
            ////    cm.Parameters.AddWithValue("@BndFtKips", dto.BndFtKips);
            ////    cm.Parameters.AddWithValue("@BridgeSpanFeet", dto.BridgeSpanFeet);
            ////    cm.Parameters.AddWithValue("@CarClass", dto.CarClass);
            ////    cm.Parameters.AddWithValue("@CarInitial", dto.CarInitial);
            ////    cm.Parameters.AddWithValue("@CooperRatingEBnd", dto.CooperRatingEBnd);
            ////    cm.Parameters.AddWithValue("@CooperRatingEFloor", dto.CooperRatingEFloor);
            ////    cm.Parameters.AddWithValue("@CooperRatingEShear", dto.CooperRatingEShear);
            ////    cm.Parameters.AddWithValue("@FloorReactKips", dto.FloorReactKips);
            ////    cm.Parameters.AddWithValue("@ShearKips", dto.ShearKips);
            ////    cm.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;

            ////    cm.ExecuteNonQuery();

            ////    dto.Id = Convert.ToInt32(cm.Parameters["@Id"].Value);
            ////}

            ////return dto;

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
            /// Instead of using an actual SQL connection and ADO.NET use the MockDb

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
            /// Instead of using an actual SQL connection and ADO.NET use the MockDb

            MockDb.CooperRatings.RemoveAll(c => c.Id == id);
        }

        #endregion

        #region Retrievers

        public CooperRatingDto Fetch(int id)
        {
            /// Instead of using an actual SQL connection and ADO.NET use the MockDb

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
            /// Instead of using an actual SQL connection and ADO.NET use the MockDb

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