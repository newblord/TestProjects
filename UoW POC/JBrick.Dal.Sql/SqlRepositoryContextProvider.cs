using System.Collections.Generic;
using System.Data;

namespace JBrick.Dal.Sql
{
	public class SqlRepositoryContextProvider : IRepositoryContextProvider<IDbConnection>
	{
		public SqlRepositoryContextProvider()
		{
			ActiveContexts = new Dictionary<string, IRepositoryContext<IDbConnection>>();
		}

		public IDictionary<string, IRepositoryContext<IDbConnection>> ActiveContexts { get; private set; }

		public IRepositoryContext<IDbConnection> GetRepositoryContext(string repositoryName)
		{
			if (!ActiveContexts.ContainsKey(repositoryName))
			{
				CreateRepositoryContext(repositoryName);
			}

			return ActiveContexts[repositoryName] as IRepositoryContext<IDbConnection>;
		}

		private void CreateRepositoryContext(string repositoryName)
		{
            ///Add Sql Connections to ActiveContexts dictionary
            /// But since the Repository in this 
            //if (string.Compare(repositoryName, IDbConnectionKey.Conn1.ToString(), true) == 0)
            //{
                    //var cxn = new SqlConnection("Data Source=sqlDev;Initial Catalog=Sandbox;Integrated Security=SSPI;");
                    //var ctx = new SqlRepositoryContext(cxn);

                    //ctx.RepositoryContext.Open();
                    //ActiveContexts.Add(repositoryName, ctx);
            //}
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
