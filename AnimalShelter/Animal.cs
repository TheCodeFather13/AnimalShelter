﻿using AnimalShelterCore;
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

        [Required]
        public string Age { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DayOfPublication { get; set; }

        [Required]
        public string Contacts { get; set; }
      
        public string ImagePath { get; set; }

        public bool IsVaccinated { get; set; }      

        public Category Category { get; set; }
    }
}