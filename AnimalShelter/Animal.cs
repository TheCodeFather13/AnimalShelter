using AnimalShelterCore;
using System.ComponentModel.DataAnnotations;

namespace AnimalShelter
{
    public class Animal
    {
        public int AnimalId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Gender { get; set; }
        public string Age { get; set; }
      
        public DateTime DayOfPublication { get; set; }

        [Required]
        public string Contacts { get; set; }  

        public string ImagePath { get; set; }

        public Category Category { get; set; }
    }
}