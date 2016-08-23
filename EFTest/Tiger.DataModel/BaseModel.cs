using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiger.DataModel
{
	public abstract class BaseModel : IValidatableObject
	{
		public virtual List<ValidationResult> ValidateModel()
		{
			var context = new ValidationContext(this);
			var results = new List<ValidationResult>();

			Validator.TryValidateObject(this, context, results, true);

			var validationObject = this as IValidatableObject;

			results.AddRange(this.Validate(context));

			return results;
		}

		public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			return new List<ValidationResult>();
		}
	}
}
