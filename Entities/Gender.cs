using MoviesApi.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Entities
{
    public class Gender: IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo con el nombre {0} es requerido")]
        [StringLength(10)]
        //[FirstLetterUppercase]
        public string Name { get; set; }
        /*[Range(18,20)]
        public int Age { get; set; }
        [CreditCard]
        public string CreditCard { get; set; }
        [Url]
        public string Url { get; set; }*/

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(!string.IsNullOrEmpty(Name))
            {
                var firstLetter = Name[0].ToString();
                if (firstLetter != firstLetter.ToUpper())
                {
                    yield return new ValidationResult("First letter should be uppercase", new string[] { nameof(Name) });
                }
            }
        }
    }
}
