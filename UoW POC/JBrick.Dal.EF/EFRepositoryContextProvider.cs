using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBrick.Dal.EF.Enums;

namespace JBrick.Dal.EF
{
	public class EFRepositoryContextProvider : IRepositoryContextProvider<DbContext>
	{
		public EFRepositoryContextProvider()
		{
			ActiveContexts = new Dictionary<string, IRepositoryContext<DbContext>>();
		}

		public IDictionary<string, IRepositoryContext<DbContext>> ActiveContexts { get; private set; }

		public IRepositoryContext<DbContext> GetRepositoryContext(string repositoryName)
		{
			if (!ActiveContexts.ContainsKey(repositoryName))
			{
				CreateRepositoryContext(repositoryName);
			}

			return ActiveContexts[repositoryName] as IRepositoryContext<DbContext>;
		}

        EFRepositoryContext _mockRepoContext = null;

		private void CreateRepositoryContext(string repositoryName)
		{
			if (string.Compare(repositoryName, EFModelTypes.MockEquipmentGuide.ToString(), true) == 0)
			{
                if (_mockRepoContext == null)
                {
                    _mockRepoContext = new EFRepositoryContext(new MockDBContext());
                }

                ActiveContexts.Add(repositoryName, _mockRepoContext);
			}
		}

		public void ClearActiveContexts()
		{
			if (ActiveContexts != null && ActiveContexts.Count > 0)
			{
				foreach (var context in ActiveContexts)
				{
					context.Value.RepositoryContext.Dispose();
				}

				ActiveContexts.Clear();
			}
		}
	}
}
