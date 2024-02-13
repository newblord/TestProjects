using System;
using System.Collections.Generic;

namespace SqlFormatter
{
    static class StandardKeywordRemapping
    {
        public static Dictionary<string, string> Instance { get; private set;  }
        static StandardKeywordRemapping()
        {
            Instance = new Dictionary<string, string>();

            Instance.Add("PROC", "PROCEDURE");
            Instance.Add("LEFT OUTER JOIN", "LEFT JOIN");
            Instance.Add("RIGHT OUTER JOIN", "RIGHT JOIN");
            Instance.Add("FULL OUTER JOIN", "FULL JOIN");
            Instance.Add("JOIN", "INNER JOIN");
            //TODO: This is now wrong in MERGE statements... we now need a scope-limitation strategy :(
            //Instance.Add("INSERT", "INSERT INTO");
            Instance.Add("TRAN", "TRANSACTION");
            Instance.Add("BEGIN TRAN", "BEGIN TRANSACTION");
            Instance.Add("COMMIT TRAN", "COMMIT TRANSACTION");
            Instance.Add("ROLLBACK TRAN", "ROLLBACK TRANSACTION");
            Instance.Add("BINARY VARYING", "VARBINARY");
            Instance.Add("CHAR VARYING", "VARCHAR");
            Instance.Add("CHARACTER", "CHAR");
            Instance.Add("CHARACTER VARYING", "VARCHAR");
            Instance.Add("DEC", "DECIMAL");
            Instance.Add("DOUBLE PRECISION", "FLOAT");
            Instance.Add("INTEGER", "INT");
            Instance.Add("NATIONAL CHARACTER", "NCHAR");
            Instance.Add("NATIONAL CHAR", "NCHAR");
            Instance.Add("NATIONAL CHARACTER VARYING", "NVARCHAR");
            Instance.Add("NATIONAL CHAR VARYING", "NVARCHAR");
			Instance.Add("NATIONAL TEXT", "NTEXT");
			Instance.Add("OUT", "OUTPUT");
			//TODO: This is wrong when a TIMESTAMP column is unnamed; ROWVERSION does not auto-name. Due to context-sensitivity, this mapping is disabled for now.
            // REF: http://msdn.microsoft.com/en-us/library/ms182776.aspx
            //Instance.Add("TIMESTAMP", "ROWVERSION");
        }
    }
}
