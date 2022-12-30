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
        [MaxLength(50), MinLength(2)]
        [RegularExpression (@"a-zA-Z")]
        public string Name { get; set; }

        [Required]
        [MaxLength(30), MinLength(10)]
        public string Contacts { get; set; }
    }
}
