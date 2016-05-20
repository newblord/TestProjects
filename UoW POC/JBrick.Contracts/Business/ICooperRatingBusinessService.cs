using System;
using System.Collections.Generic;

namespace JBrick.Contracts.Business
{
    public interface ICooperRatingBusinessService
	 {
		 #region Modifiers

		 ICooperRatingModel CreateCooperRating(ICooperRatingModel model);
		 ICooperRatingModel UpdateCooperRating(ICooperRatingModel model);
		 void DeleteCooperRating(int id);

		 #endregion

		 #region Retrievers

		 ICooperRatingModel FetchCooperRating(int id);
		 IEnumerable<ICooperRatingModel> FetchAllCooperRating();

		 #endregion
    }
}
