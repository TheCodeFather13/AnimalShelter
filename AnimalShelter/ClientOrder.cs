using AnimalShelter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterCore
{
    public class ClientOrder
    {
        public int ClientOrderId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Максимальная длина 50 букв"), MinLength(2, ErrorMessage = "Минимальная длина 2 буквы")]
       // [RegularExpression (@"a-zA-Z '-'", ErrorMessage = "Необходимы буквы от а до я!")]
        public string Name { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Максимальная длина 30 символов"), MinLength(5, ErrorMessage = "Минимальная длина 5 символов")]       
        public string Contacts { get; set; }

        public string InfoAboutAnimal { get; set; }
    }
}
