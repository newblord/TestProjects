
namespace DatabaseGenerationToolExt.DatabaseGeneration.Base
{
	public class Column
	{
		public string Name { get; set; } // Raw name of the column as obtained from the database
		public string NameHumanCase { get; set; } // Name adjusted for C# output
		public string ParameterName { get; set; } // Name with first letter as lowercase, based of NameHumanCase

		public string SqlPropertyType { get; set; }
		public string PropertyType { get; set; }
		public int MaxLength { get; set; }
		public int Ordinal { get; set; }

		private bool _isNullable;
		public bool IsNullable
		{
			get
			{
				return _isNullable && 
							!Helpers.PropertyTypeHelper.NotNullable.Contains(PropertyType.ToLower());
			}
			set
			{
				_isNullable = value;
			}
		}

		public void WrapPropertyTypeIfNullable()
		{
			if (IsNullable)
			PropertyType = Helpers.Global.DatabaseSetting.NullableShortHand ? $"{PropertyType}?" : $"Nullable<{PropertyType}>";
		}
	}
}
