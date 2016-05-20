using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBrick.Contracts.Logging;

namespace JBrick.Core.Logging
{
	public class ConsoleLogger : ILogger
	{
		public void Info(string message)
		{
			Console.WriteLine("InfoLog: " + message);
		}

		public void Warn(string message)
		{
			Console.WriteLine("InfoLog: " + message);
		}

		public void Debug(string message)
		{
			Console.WriteLine("InfoLog: " + message);
		}

		public void Error(string message)
		{
			Console.WriteLine("InfoLog: " + message);
		}

		public void Error(string message, Exception ex)
		{
			Console.WriteLine("InfoLog: " + message + " ; Exception: " + ex.Message);
		}

		public void Error(Exception ex)
		{
			Console.WriteLine("InfoLog: " + ex.Message);
		}

		public void Fatal(string message)
		{
			Console.WriteLine("InfoLog: " + message);
		}

		public void Fatal(string message, Exception ex)
		{
			Console.WriteLine("InfoLog: " + message + " ; Exception: " + ex.Message);
		}

		public void Fatal(Exception ex)
		{
			Console.WriteLine("InfoLog: " + ex.Message);
		}
	}
}
