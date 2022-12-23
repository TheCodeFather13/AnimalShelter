using AnimalShelter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterCore
{
    public class ClientOrder
    {
        public int ClientOrderId { get; set; }
     
        public string Name { get; set; }
        
        public string Contacts { get; set; }
    }
}
