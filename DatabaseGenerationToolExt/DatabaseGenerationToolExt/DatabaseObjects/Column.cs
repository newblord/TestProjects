using DatabaseGenerationToolExt.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseObjects
{
	public class Column
	{
		public string Name { get; set; } // Raw name of the column as obtained from the database
		public string NameHumanCase { get; set; } // Name adjusted for C# output
		public string ParameterName { get; set; } // Name with first letter as lowercase, based of NameHumanCase

		public int DateTimePrecision { get; set; }
		public string Default { get; set; }
		public int MaxLength { get; set; }
		public int Precision { get; set; }
		public string SqlPropertyType { get; set; }
		public string PropertyType { get; set; }
		public int Scale { get; set; }
		public int Ordinal { get; set; }
		public int PrimaryKeyOrdinal { get; set; }
		public string ExtendedProperty { get; set; }
		public string SummaryComments { get; set; }

		public bool IsIdentity { get; set; }

		private bool _isNullable;
		public bool IsNullable
		{
			get
			{
				return _isNullable && !PropertyTypeHelper.NotNullable.Contains(PropertyType.ToLower());
			}
			set
			{
				_isNullable = value;
			}
		}
		public bool IsPrimaryKey { get; set; }
		public bool IsStoreGenerated { get; set; }
		public bool IsRowVersion { get; set; }
		public bool IsConcurrencyToken { get; set; } //  Manually set via callback
		public bool IsFixedLength { get; set; }
		public bool IsUnicode { get; set; }
		public bool IsMaxLength { get; set; }
		public bool Hidden { get; set; }
		public bool IsForeignKey { get; set; }

		public string Config { get; set; }
		public List<string> ConfigForeignKeys { get; set; }
		public string Entity { get; set; }
		public List<string> EntityForeignKeys { get; set; }
		public string InterfaceEntity { get; set; }

		public Table ParentTable { get; set; }

		public Column()
		{
			ConfigForeignKeys = new List<string>();
			EntityForeignKeys = new List<string>();
		}

		public void ResetNavigationProperties()
		{
			ConfigForeignKeys = new List<string>();
			EntityForeignKeys = new List<string>();
		}

		private void SetupEntity(CommentsStyle includeComments)
		{
			var comments = string.Empty;
			if (includeComments != CommentsStyle.None)
			{
				comments = Name;
				if (IsPrimaryKey)
				{
					comments += " (Primary key)";
				}

				if (MaxLength > 0)
					comments += string.Format(" (length: {0})", MaxLength);
			}

			var inlineComments = includeComments == CommentsStyle.AtEndOfField ? " // " + comments : string.Empty;

			SummaryComments = string.Empty;
			if (includeComments == CommentsStyle.InSummaryBlock && !string.IsNullOrEmpty(comments))
			{
				SummaryComments = comments;
			}

			if (IsNullable)
				PropertyType = String.Format(Global.Setting.NullableShortHand ? "{0}?" : "Nullable<{0}>", PropertyType);

			Entity = string.Format("public {0} {1} {{ get; {2}set; }}{3}", PropertyType, NameHumanCase, IsComputed ? "private " : string.Empty, inlineComments);
			InterfaceEntity = string.Format("{0} {1} {{ get; set; }}{2}", PropertyType, NameHumanCase, inlineComments);
		}

		public bool IsComputed
		{
			get
			{
				return IsStoreGenerated && !IsIdentity;
			}
		}

		private void SetupConfig()
		{
			string databaseGeneratedOption = string.Empty;
			if (IsIdentity)
				databaseGeneratedOption = ".HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)";
			if (IsComputed)
				databaseGeneratedOption = ".HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)";
			if (IsPrimaryKey && !IsIdentity && !IsStoreGenerated)
				databaseGeneratedOption = ".HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)";

			Config = string.Format("Property(x => x.{0}).HasColumnName(@\"{1}\"){2}{3}{4}{5}{6}{7}{8}{9}{10}{11};", NameHumanCase, Name,
												(IsNullable) ? ".IsOptional()" : ".IsRequired()",
												(IsFixedLength || IsRowVersion) ? ".IsFixedLength()" : "",
												(IsUnicode) ? string.Empty : ".IsUnicode(false)",
												".HasColumnType(\"" + SqlPropertyType + "\")",
												(!IsMaxLength && MaxLength > 0) ? ".HasMaxLength(" + MaxLength + ")" : string.Empty,
												(IsMaxLength) ? ".IsMaxLength()" : string.Empty,
												(Scale > 0) ? ".HasPrecision(" + Precision + "," + Scale + ")" : string.Empty,
												(IsRowVersion) ? ".IsRowVersion()" : string.Empty,
												(IsConcurrencyToken) ? ".IsConcurrencyToken()" : string.Empty,
												databaseGeneratedOption);
		}

		public void SetupEntityAndConfig(CommentsStyle includeComments)
		{
			SetupEntity(includeComments);
			SetupConfig();
		}

		public void CleanUpDefault()
		{
			if (string.IsNullOrWhiteSpace(Default))
			{
				Default = string.Empty;
				return;
			}

			// Remove outer brackets
			while (Default.First() == '(' && Default.Last() == ')' && Default.Length > 2)
			{
				Default = Default.Substring(1, Default.Length - 2);
			}

			// Remove unicode prefix
			if (IsUnicode && Default.StartsWith("N") && !Default.Equals("NULL", StringComparison.InvariantCultureIgnoreCase))
				Default = Default.Substring(1, Default.Length - 1);

			if (Default.First() == '\'' && Default.Last() == '\'' && Default.Length >= 2)
				Default = string.Format("\"{0}\"", Default.Substring(1, Default.Length - 2));

			string lower = Default.ToLower();
			string lowerPropertyType = PropertyType.ToLower();

			// Cleanup default
			switch (lowerPropertyType)
			{
				case "bool":
					Default = (Default == "0" || lower == "\"false\"" || lower == "false") ? "false" : "true";
					break;

				case "string":
				case "datetime":
				case "timespan":
				case "datetimeoffset":
					if (Default.First() != '"')
						Default = string.Format("\"{0}\"", Default);
					if (Default.Contains('\\') || Default.Contains('\r') || Default.Contains('\n'))
						Default = "@" + Default;
					break;

				case "long":
				case "short":
				case "int":
				case "double":
				case "float":
				case "decimal":
				case "byte":
				case "guid":
					if (Default.First() == '\"' && Default.Last() == '\"' && Default.Length > 2)
						Default = Default.Substring(1, Default.Length - 2);
					break;

				case "byte[]":
				case "System.Data.Entity.Spatial.DbGeography":
				case "System.Data.Entity.Spatial.DbGeometry":
					Default = string.Empty;
					break;
			}

			// Ignore defaults we cannot interpret (we would need SQL to C# compiler)
			if (lower.StartsWith("create default"))
			{
				Default = string.Empty;
				return;
			}

			if (string.IsNullOrWhiteSpace(Default))
			{
				Default = string.Empty;
				return;
			}

			// Validate default
			switch (lowerPropertyType)
			{
				case "long":
					long l;
					if (!long.TryParse(Default, out l))
						Default = string.Empty;
					break;

				case "short":
					short s;
					if (!short.TryParse(Default, out s))
						Default = string.Empty;
					break;

				case "int":
					int i;
					if (!int.TryParse(Default, out i))
						Default = string.Empty;
					break;

				case "datetime":
					DateTime dt;
					if (!DateTime.TryParse(Default, out dt))
						Default = lower.Contains("getdate()") ? "DateTime.Now" : lower.Contains("getutcdate()") ? "DateTime.UtcNow" : string.Empty;
					else
						Default = string.Format("DateTime.Parse({0})", Default);
					break;

				case "datetimeoffset":
					DateTimeOffset dto;
					if (!DateTimeOffset.TryParse(Default, out dto))
						Default = lower.Contains("sysdatetimeoffset") ? "DateTimeOffset.Now" : lower.Contains("sysutcdatetime") ? "DateTimeOffset.UtcNow" : string.Empty;
					else
						Default = string.Format("DateTimeOffset.Parse({0})", Default);
					break;

				case "timespan":
					TimeSpan ts;
					if (!TimeSpan.TryParse(Default, out ts))
						Default = string.Empty;
					else
						Default = string.Format("TimeSpan.Parse({0})", Default);
					break;

				case "double":
					double d;
					if (!double.TryParse(Default, out d))
						Default = string.Empty;
					break;

				case "float":
					float f;
					if (!float.TryParse(Default, out f))
						Default = string.Empty;
					break;

				case "decimal":
					decimal dec;
					if (!decimal.TryParse(Default, out dec))
						Default = string.Empty;
					else
						Default += "m";
					break;

				case "byte":
					byte b;
					if (!byte.TryParse(Default, out b))
						Default = string.Empty;
					break;

				case "bool":
					bool x;
					if (!bool.TryParse(Default, out x))
						Default = string.Empty;
					break;

				case "string":
					if (lower.Contains("newid()") || lower.Contains("newsequentialid()"))
						Default = "Guid.NewGuid().ToString()";
					if (lower.StartsWith("space("))
						Default = "\"\"";
					if (lower == "null")
						Default = string.Empty;
					break;

				case "guid":
					if (lower.Contains("newid()") || lower.Contains("newsequentialid()"))
						Default = "Guid.NewGuid()";
					else if (lower.Contains("null"))
						Default = "null";
					else
						Default = string.Format("Guid.Parse(\"{0}\")", Default);
					break;
			}
		}
	}
}
