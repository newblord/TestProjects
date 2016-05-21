using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Dal.Sql.EquipmentGuideMock
{
    public class MockCooperRatingDataTable
    {
        public int Id { get; set; }
        public string CarInitial { get; set; }
        public string CarClass { get; set; }
        public Int16 BridgeSpanFeet { get; set; }
        public int BndFtKips { get; set; }
        public decimal CooperRatingEBnd { get; set; }
        public Int16 ShearKips { get; set; }
        public decimal CooperRatingEShear { get; set; }
        public Int16 FloorReactKips { get; set; }
        public decimal CooperRatingEFloor { get; set; }
    }
}
