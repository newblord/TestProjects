using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Contracts.Logging.Enums
{
	/// <summary>
	/// Enumeration to indicate logging severity
	/// </summary>
	[Flags]
	public enum LogLevel
	{
		/// <summary>
		/// With None level Logging will not occur.
		/// </summary>
		None = 0,

		/// <summary>
		/// Fatal level is used to log fatal exceptions such as unhandled exceptions
		/// </summary>
		Fatal = 1,

		/// <summary>
		/// Error level is used to log all exceptions
		/// </summary>
		Error = 2,

		/// <summary>
		/// Warn level is used to log application warning information such as if a configuration settings is missing 
		/// </summary>
		Warn = 3,

		/// <summary>
		/// Info level is used to log audit or application management type information such as when someone logs into the systems
		/// </summary>
		Info = 4,

		/// <summary>
		/// Debug level is used to log debugging information
		/// </summary>
		Debug = 5
	}
}
