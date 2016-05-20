using System;

namespace JBrick.Contracts.Business
{
	public interface ICooperRatingModel
	{
        int Id { get; set; }
		string CarInitial { get; set; }
		string CarClass { get; set; }
		Int16 BridgeSpanFeet { get; set; }
		int BndFtKips { get; set; }
		decimal CooperRatingEBnd { get; set; }
		Int16 ShearKips { get; set; }
		decimal CooperRatingEShear { get; set; }
		Int16 FloorReactKips { get; set; }
		decimal CooperRatingEFloor { get; set; }
	}
}