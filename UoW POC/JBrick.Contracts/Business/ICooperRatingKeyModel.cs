using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Contracts.Business
{
	public interface ICooperRatingKeyModel
	{
		string CarInitial { get; set; }
		string CarClass { get; set; }
		Int16 BridgeSpanFeet { get; set; }
	}
}
