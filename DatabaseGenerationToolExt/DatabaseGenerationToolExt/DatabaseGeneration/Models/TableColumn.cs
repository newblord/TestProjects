using DatabaseGenerationToolExt.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseGenerationToolExt.DatabaseGeneration.Models
{
	public class TableColumn : Base.Column
	{
		public int DateTimePrecision { get; set; }
		public string DefaultValue { get; set; }
		public int Precision { get; set; }
		public int Scale { get; set; }
		public int PrimaryKeyOrdinal { get; set; }
		public string ExtendedProperty { get; set; }
		public string SummaryComments { get; set; }

		public bool IsIdentity { get; set; }

		public bool IsPrimaryKey { get; set; }
		public bool IsStoreGenerated { get; set; }
		public bool IsRowVersion { get; set; }
		public bool IsConcurrencyToken { get; set; } //  Manually set via callback
		public bool IsFixedLength { get; set; }
		public bool IsUnicode { get; set; }
		public bool IsMaxLength { get; set; }
		public bool Hidden { get; set; }
		public bool IsForeignKey { get; set; }

		public bool IsComputed
		{
			get
			{
				return IsStoreGenerated && !IsIdentity;
			}
		}

		public string Config { get; set; }
		public List<string> ConfigForeignKeys { get; set; }
		public string Entity { get; set; }
		public List<string> EntityForeignKeys { get; set; }
		public string InterfaceEntity { get; set; }

		public Table ParentTable { get; set; }

		public List<string> DataAnnotations { get; set; }

		public TableColumn()
		{
			ConfigForeignKeys = new List<string>();
			EntityForeignKeys = new List<string>();
			DataAnnotations = new List<string>();
		}

		public void ResetNavigationProperties()
		{
			ConfigForeignKeys = new List<string>();
			EntityForeignKeys = new List<string>();
		}

		public void SetupEntityAndConfig(CommentsStyle includeComments)
		{
			SetupEntity(includeComments);
			SetupConfig();
			SetupDataAnnotations();
			CleanUpDefault();
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

			WrapPropertyTypeIfNullable();

			Entity = string.Format("public {0} {1} {{ get; {2}set; }}{3}", PropertyType, NameHumanCase, IsComputed ? "private " : string.Empty, inlineComments);
			InterfaceEntity = string.Format("{0} {1} {{ get; set; }}{2}", PropertyType, NameHumanCase, inlineComments);
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

		private void SetupDataAnnotations()
		{
			// Example of adding a [Required] data annotation attribute to all non-null fields
			//if (!c.IsNullable)
			//	 WriteLine("[System.ComponentModel.DataAnnotations.Required] " + c.Entity);

			if (Global.DatabaseSetting.UseDataAnnotations)
			{
				if (IsIdentity)
					DataAnnotations.Add("[DatabaseGenerated(DatabaseGeneratedOption.Identity)]");
				if (IsComputed)
					DataAnnotations.Add("[DatabaseGenerated(DatabaseGeneratedOption.Computed)]");
				if (IsPrimaryKey && !IsIdentity && !IsStoreGenerated)
					DataAnnotations.Add("[DatabaseGenerated(DatabaseGeneratedOption.None)]");

				if (IsPrimaryKey)
					DataAnnotations.Add("[Key]");
				if (!IsNullable)
					DataAnnotations.Add("[Required]");
				if (!IsMaxLength && MaxLength > 0)
				{
					DataAnnotations.Add(string.Format("[MaxLength({0})]", MaxLength));
					if (PropertyType.Equals("string", StringComparison.InvariantCultureIgnoreCase))
						DataAnnotations.Add(string.Format("[StringLength({0})]", MaxLength));
				}
				if (IsMaxLength)
					DataAnnotations.Add("[MaxLength]");
				if (IsRowVersion)
					DataAnnotations.Add("[Timestamp]");

				DataAnnotations.Add(string.Format("[Column(\"{0}\", Order = \"{1}\" TypeName=\"{2}\")]"
									 , Name
									 , Ordinal
									 , SqlPropertyType
								//,IsPrimaryKey ? string.Format(", Order = {0}", PrimaryKeyOrdinal) : ""
								));
			}
		}

		private void CleanUpDefault()
		{
			if (string.IsNullOrWhiteSpace(DefaultValue))
			{
				DefaultValue = string.Empty;
				return;
			}

			// Remove outer brackets
			while (DefaultValue.First() == '(' && DefaultValue.Last() == ')' && DefaultValue.Length > 2)
			{
				DefaultValue = DefaultValue.Substring(1, DefaultValue.Length - 2);
			}

			// Remove unicode prefix
			if (IsUnicode && DefaultValue.StartsWith("N") && !DefaultValue.Equals("NULL", StringComparison.InvariantCultureIgnoreCase))
				DefaultValue = DefaultValue.Substring(1, DefaultValue.Length - 1);

			if (DefaultValue.First() == '\'' && DefaultValue.Last() == '\'' && DefaultValue.Length >= 2)
				DefaultValue = string.Format("\"{0}\"", DefaultValue.Substring(1, DefaultValue.Length - 2));

			string lower = DefaultValue.ToLower();
			string lowerPropertyType = PropertyType.ToLower();

			// Cleanup default
			switch (lowerPropertyType)
			{
				case "bool":
					DefaultValue = (DefaultValue == "0" || lower == "\"false\"" || lower == "false") ? "false" : "true";
					break;

				case "string":
				case "datetime":
				case "timespan":
				case "datetimeoffset":
					if (DefaultValue.First() != '"')
						DefaultValue = string.Format("\"{0}\"", DefaultValue);
					if (DefaultValue.Contains('\\') || DefaultValue.Contains('\r') || DefaultValue.Contains('\n'))
						DefaultValue = "@" + DefaultValue;
					break;

				case "long":
				case "short":
				case "int":
				case "double":
				case "float":
				case "decimal":
				case "byte":
				case "guid":
					if (DefaultValue.First() == '\"' && DefaultValue.Last() == '\"' && DefaultValue.Length > 2)
						DefaultValue = DefaultValue.Substring(1, DefaultValue.Length - 2);
					break;

				case "byte[]":
				case "System.Data.Entity.Spatial.DbGeography":
				case "System.Data.Entity.Spatial.DbGeometry":
					DefaultValue = string.Empty;
					break;
			}

			// Ignore defaults we cannot interpret (we would need SQL to C# compiler)
			if (lower.StartsWith("create default"))
			{
				DefaultValue = string.Empty;
				return;
			}

			if (string.IsNullOrWhiteSpace(DefaultValue))
			{
				DefaultValue = string.Empty;
				return;
			}

			// Validate default
			switch (lowerPropertyType)
			{
				case "long":
					long l;
					if (!long.TryParse(DefaultValue, out l))
						DefaultValue = string.Empty;
					break;

				case "short":
					short s;
					if (!short.TryParse(DefaultValue, out s))
						DefaultValue = string.Empty;
					break;

				case "int":
					int i;
					if (!int.TryParse(DefaultValue, out i))
						DefaultValue = string.Empty;
					break;

				case "datetime":
					DateTime dt;
					if (!DateTime.TryParse(DefaultValue, out dt))
						DefaultValue = lower.Contains("getdate()") ? "DateTime.Now" : lower.Contains("getutcdate()") ? "DateTime.UtcNow" : string.Empty;
					else
						DefaultValue = string.Format("DateTime.Parse({0})", DefaultValue);
					break;

				case "datetimeoffset":
					DateTimeOffset dto;
					if (!DateTimeOffset.TryParse(DefaultValue, out dto))
						DefaultValue = lower.Contains("sysdatetimeoffset") ? "DateTimeOffset.Now" : lower.Contains("sysutcdatetime") ? "DateTimeOffset.UtcNow" : string.Empty;
					else
						DefaultValue = string.Format("DateTimeOffset.Parse({0})", DefaultValue);
					break;

				case "timespan":
					TimeSpan ts;
					if (!TimeSpan.TryParse(DefaultValue, out ts))
						DefaultValue = string.Empty;
					else
						DefaultValue = string.Format("TimeSpan.Parse({0})", DefaultValue);
					break;

				case "double":
					double d;
					if (!double.TryParse(DefaultValue, out d))
						DefaultValue = string.Empty;
					break;

				case "float":
					float f;
					if (!float.TryParse(DefaultValue, out f))
						DefaultValue = string.Empty;
					break;

				case "decimal":
					decimal dec;
					if (!decimal.TryParse(DefaultValue, out dec))
						DefaultValue = string.Empty;
					else
						DefaultValue += "m";
					break;

				case "byte":
					byte b;
					if (!byte.TryParse(DefaultValue, out b))
						DefaultValue = string.Empty;
					break;

				case "bool":
					bool x;
					if (!bool.TryParse(DefaultValue, out x))
						DefaultValue = string.Empty;
					break;

				case "string":
					if (lower.Contains("newid()") || lower.Contains("newsequentialid()"))
						DefaultValue = "Guid.NewGuid().ToString()";
					if (lower.StartsWith("space("))
						DefaultValue = "\"\"";
					if (lower == "null")
						DefaultValue = string.Empty;
					break;

				case "guid":
					if (lower.Contains("newid()") || lower.Contains("newsequentialid()"))
						DefaultValue = "Guid.NewGuid()";
					else if (lower.Contains("null"))
						DefaultValue = "null";
					else
						DefaultValue = string.Format("Guid.Parse(\"{0}\")", DefaultValue);
					break;
			}
		}
	}
}
