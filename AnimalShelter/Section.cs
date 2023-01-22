using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterCore
{
    public class Section
    {
        public int SectionId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string MainText { get; set; }

        [Required]   
        public string ImagePath { get; set; }
        public DateTime PublicDate { get; set; }
    }
}
