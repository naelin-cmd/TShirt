using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TShirtAPI.Model
{
    public class TShirt
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string TShirtSize { get; set; }
      
        public string Color { get; set; }
        public string ShippingAddress { get; set; }

    }
}
