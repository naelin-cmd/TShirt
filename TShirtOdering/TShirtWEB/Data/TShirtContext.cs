using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShirtWEB.Model;

namespace TShirtWEB.Data
{
    public class TShirtContext: DbContext
    {
        public TShirtContext(DbContextOptions<TShirtContext>options)
            :base(options)
        {

        }
        public DbSet<TShirt> TshirtInfo { get; set; }
        
    }

}
