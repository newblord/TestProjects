﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseGeneration.Models
{
	public class EnumEntry
	{
		public string Value { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public string Description { get; set; }
		public bool ValueIsNumeric { get; set; }
	}
}
