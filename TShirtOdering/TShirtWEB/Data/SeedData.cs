using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShirtWEB.Model;

namespace TShirtWEB.Data
{
    public static class SeedData
    {
        public static void Initialize(TShirtContext context)
        {
            if (!context.TshirtInfo.Any())
            {
                context.TshirtInfo.AddRange(
            new TShirt
            {

                Name = "ejhef",
                Gender = "ddsgd",
                TShirtSize = "dgdrg",
                Color = "rrthsr",
                ShippingAddress = "hrhsr"
            }

            );
                context.SaveChanges();
            }
        }
    }
}

