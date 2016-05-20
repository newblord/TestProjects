using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBrick.Contracts.Logging
{
	/// <summary>
	/// An interface that any logging provider can implement
	/// </summary>
	public interface ILogger
	{
		void Debug(string message);
		void Info(string message);
		void Warn(string message);
		void Error(string message);
		void Error(string message, Exception x);
		void Error(Exception x);
		void Fatal(string message);
		void Fatal(string message, Exception x);
		void Fatal(Exception x);
	}
}
