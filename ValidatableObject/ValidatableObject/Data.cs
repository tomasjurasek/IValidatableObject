using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ValidatableObject
{
    public class Data : IValidatableObject
    {
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Enabled)
            {
                yield return new ValidationResult("Name is required! ", new[] { nameof(Name) });
            }
        }
    }
}


