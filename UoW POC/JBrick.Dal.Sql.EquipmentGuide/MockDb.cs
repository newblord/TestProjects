using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Dal.Sql.MockEquipmentGuide
{
   public static class MockDb
   {
      public static List<MockCooperRatingDataTable> CooperRatings { get; private set; }

      static MockDb()
      {
         GetDefaultCooperRatings();
      }

      private static void GetDefaultCooperRatings()
      {
         CooperRatings = new List<MockCooperRatingDataTable>
            {
               new MockCooperRatingDataTable
               {
                   Id = 1, BndFtKips = 5, BridgeSpanFeet = 12, CarClass = "1000", CarInitial = "DTTX", CooperRatingEBnd = 10.6M, CooperRatingEFloor = 12, CooperRatingEShear = 5.2M, FloorReactKips = 2, ShearKips = 3
               },
               new MockCooperRatingDataTable
               {
                   Id = 2, BndFtKips = 3, BridgeSpanFeet = 18, CarClass = "2000", CarInitial = "DTTX", CooperRatingEBnd = 12.2M, CooperRatingEFloor = 2, CooperRatingEShear = 2.2M, FloorReactKips = 2, ShearKips = 3
               }
           };
      }
   }
}