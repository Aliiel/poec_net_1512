using System.ComponentModel.DataAnnotations;

namespace ModelDemo.Validation
{
    // Attribut pour vérifier un age minimum
    public class MinimumAgeAttribute : ValidationAttribute
    {
        // propriété pour vérifier un $age minimum
        private readonly int _minimumAge;

        // constructeur avec l'âge minimum en params
        public MinimumAgeAttribute(int MinimumAge)
        {
            _minimumAge = MinimumAge;
            ErrorMessage = $"Vous devez avoir au moins {MinimumAge} ans ";
        }

        protected override ValidationResult? IsValid (object? value, ValidationContext validationContext)
        {
            if (value is DateTime DateNaissance)
            {
                // On calcule l'âge
                var age = DateTime.Now.Year - DateNaissance.Year;

                if (DateNaissance > DateTime.Now.AddYears(-age))
                {
                    age --;
                }

                if (age >= _minimumAge)
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult(ErrorMessage);
        }
    }
}
