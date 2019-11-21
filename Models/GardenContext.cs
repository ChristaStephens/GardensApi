
using Microsoft.EntityFrameworkCore;


namespace GardensApi.Models
{
    //inherits from dbcontext
    public class GardenContext : DbContext
    {
        public GardenContext(DbContextOptions<GardenContext> options)
            :base (options)
        {

        }
        //this will be a table in our database
        public DbSet<Garden> GardenItems {get; set;}
    }
}




//database context
