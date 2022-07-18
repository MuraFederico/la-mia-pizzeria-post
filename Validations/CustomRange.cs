using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Validations
{
    public class CustomRange : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {

            return base.IsValid(value, validationContext);
        }
    }
}
