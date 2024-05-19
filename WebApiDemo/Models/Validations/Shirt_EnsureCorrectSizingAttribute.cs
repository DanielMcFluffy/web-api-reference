using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models.Validations
{
    public class Shirt_EnsureCorrectSizingAttribute: ValidationAttribute //model validation attribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //we first get the model object from the validation context
            var shirt = validationContext.ObjectInstance as Shirt;

            if (shirt != null && shirt.Gender != null)
            {
                if (shirt.Gender.Equals("men", StringComparison.OrdinalIgnoreCase) && shirt.Size < 8)
                {
                    return new ValidationResult("The size has to be greather or equal to 8");
                }
                else if (shirt.Gender.Equals("women", StringComparison.OrdinalIgnoreCase) && shirt.Size <6)
                {
                    return new ValidationResult("The size has to be greater than or equal to 6");
                }
            }

            return ValidationResult.Success;
        }
    }
}
