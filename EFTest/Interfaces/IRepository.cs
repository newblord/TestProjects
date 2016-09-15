using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
	public interface IRepository<T>
	{

		T Insert(T data);
		T Update(T data);
		void Delete(int id);
		T FindById(int id);
		IEnumerable<T> GetAll();

	}
}
