using System.Collections.Generic;
using System;

namespace JBrick.Dal
{
	public interface ICooperRatingRepository
	{
		#region Modifiers

		CooperRatingDto Insert(CooperRatingDto data);
		CooperRatingDto Update(CooperRatingDto data);
		void Delete(int id);

		#endregion

		#region Retrievers

		CooperRatingDto Fetch(int id);
		IEnumerable<CooperRatingDto> FetchAll();

		#endregion
	}
}