using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ValidatableObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var myData = new Data
            {
                Enabled = true
            };

            var results = new List<ValidationResult>();
            Validator.TryValidateObject(myData, new ValidationContext(myData, null, null), results, true);

            foreach (var result in results)
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
    }
}
