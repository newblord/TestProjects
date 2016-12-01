using DatabaseGenerationToolExt.DatabaseGeneration.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.Helpers
{
	public static class StoredProcedureHelper
	{

		

		/// <summary>
		/// StoredProcedure renaming ************************************************************************************************************
		/// Use the following function to rename stored procs such as sp_CreateOrderHistory to CreateOrderHistory, my_sp_shipments to Shipments, etc.
		/// Example:
		/// StoredProcedureRename = (name, schema) =>
		/// {
		///	    if (name.StartsWith("sp_"))
		///		    name = name.Remove(0, 3);
		///	    return name.Replace("my_sp_", "");
		/// };
		/// </summary>
		public static string StoredProcedureRename(string name, string schema)
		{
			return name;  // Do nothing by default
		}
		
	}
}
