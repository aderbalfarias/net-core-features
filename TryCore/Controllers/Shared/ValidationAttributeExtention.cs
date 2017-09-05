using System.ComponentModel.DataAnnotations;

namespace Gsys.Mvc.Models.Shared
{
    public class ValidationAttributeExtention : ValidationAttribute
    {
        private readonly int _espace;
        public ValidationAttributeExtention(int espace)
            : base(@"{0} Contains spaces beyond allowed")
        {
            _espace = espace;
        }
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var valueAsSting = value?.ToString();
            if (valueAsSting?.Split(' ').Length > _espace)
            {
                var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                return new ValidationResult(errorMessage);
            }

            return ValidationResult.Success;
        }
    }
}