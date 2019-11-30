using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TShirtWEB.Model
{
    public class TShirt
    {

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string TShirtSize { get; set; }
        [Required]
        public DateTime DateofOrder { get; set; }
        [Required]

        public string Color { get; set; }
        [Required]
        public string ShippingAddress { get; set; }

    }
}
