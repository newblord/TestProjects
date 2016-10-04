using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiger.Dal.Templates.DatabaseObjects
{
	public enum Relationship
	{
		OneToOne,
		OneToMany,
		ManyToOne,
		ManyToMany,
		DoNotUse
	}

	[Flags]
	public enum Elements
	{
		None = 0,
		Poco = 1,
		Context = 2,
		UnitOfWork = 4,
		PocoConfiguration = 8,
		PocoInterface = 16,
		Repository = 32,
		RepositoryInterface = 64
	}

	[Flags]
	public enum CommentsStyle
	{
		None,
		InSummaryBlock,
		AtEndOfField
	}

	public enum StoredProcedureParameterMode
	{
		In,
		InOut,
		Out
	}
}
