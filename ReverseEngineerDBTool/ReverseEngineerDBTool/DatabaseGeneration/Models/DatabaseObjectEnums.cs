using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEngineerDBTool.DatabaseGeneration.Models
{
    public enum Relationship
    {
        OneToOne,
        OneToMany,
        ManyToOne,
        ManyToMany,
        DoNotUse
    }

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
