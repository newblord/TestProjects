using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using JBrick.Contracts.Business;
using JBrick.BL.Core;

namespace JBrick.BL.EquipmentGuide
{
	public class CooperRatingModel : BusinessModelBase, ICooperRatingModel
	{
        public int Id { get; set; }

		[Required(ErrorMessage = "Car Initial is required.")]
		[StringLength(4)]
		[Display(Name = "Car Class")]
		public string CarInitial { get; set; }

		[Required(ErrorMessage = "Car Class is required.")]
		[StringLength(6)]
		[Display(Name = "Car Initial")]
		public string CarClass { get; set; }

		[Required(ErrorMessage = "Bridge span in Feet is required.")]
		[Range(1, 9999, ErrorMessage= "Bridge Span Feet should be a numerical value with up to 4 characters in XXXX format.  Minimum value should be 1.")]
		[Display(Name = "Bridge Span in Feet")]
		public Int16 BridgeSpanFeet { get; set; }

		[Required(ErrorMessage = "Bnd Feet Kips is required.")]
        [Range(0, 999999, ErrorMessage = "Bnd Ft Kips should be a numerical value with up to 6 characters in length and in XXXXXX format.")]
		[Display(Name = "Bnd Feet Kips")]
		public int BndFtKips { get; set; }

		[Required(ErrorMessage = "Cooper Rating E Bnd is required.")]
		[Display(Name = "Cooper Rating E Bnd")]
        [RegularExpression(@"^\d{0,2}(\.\d{1,3})?%?$", ErrorMessage = "Cooper Rat E Bnd should be a valid decimal value in XX.XXX format.")]
		public decimal CooperRatingEBnd { get; set; }

		[Required(ErrorMessage = "Shear Kips is required.")]
        [Range(0, 9999, ErrorMessage = "Shear Kips should be a numerical value with up to 4 characters in length and in XXXX format.")]
		[Display(Name = "Shear Kips")]
		public Int16 ShearKips { get; set; }

		[Required(ErrorMessage = "Cooper Rating E Shear is required.")]
		[Display(Name = "Cooper Rating E Shear")]
        [RegularExpression(@"^\d{0,3}(\.\d{1,3})?%?$", ErrorMessage = "Cooper Rate E Shear should be a valid decimal value in XXX.XXX format")]
		public decimal CooperRatingEShear { get; set; }

		[Required(ErrorMessage = "Floor React Kips is required.")]
        [Range(0, 9999, ErrorMessage = "Floor React Kips should be a numerical value up to 4 characters in length and in XXXX format.")]
		[Display(Name = "Floor React Kips")]
		public Int16 FloorReactKips { get; set; }

		[Required(ErrorMessage = "Cooper Rating E Floor is required.")]
		[Display(Name = "Cooper Rating E Floor")]
        [RegularExpression(@"^\d{0,3}(\.\d{1,3})?%?$", ErrorMessage = "Cooper Rat E Floor should be a valid decimal value in XXX.XXX format.")]
		public decimal CooperRatingEFloor { get; set; }

		public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (String.IsNullOrWhiteSpace(CarInitial))
			{
				yield return new ValidationResult("does not accept blank...", new[] { "", "" });
			}

			if (String.IsNullOrWhiteSpace(CarClass))
			{
				yield return new ValidationResult("does not accept blank...", new[] { "", "" });
			}

			if (BridgeSpanFeet <= 0)
			{
				yield return new ValidationResult("does not accept less than or equal to zero...", new[] { "", "" });
			}

		}
	}
}