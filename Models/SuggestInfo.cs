using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class SuggestInfo
    {
        [Required]
        public string UserName { get; set; } 
        [Required]
        public string SuggestedRestaurant { get; set; }
        [Required]
        public string SuggestedFavoriteDish { get; set; } 
        //It only allows phone number 
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        [Required]
        public string SuggestedPhone { get; set; }

    }
}
