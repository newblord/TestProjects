using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JBrick.BL.Core
{
   public abstract class BusinessModelBase : IValidatableObject
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
