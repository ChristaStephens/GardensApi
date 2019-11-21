
using Microsoft.EntityFrameworkCore;


namespace GardensApi.Models
{
    //inherits from dbcontext
    //our db context need to be aware of our appsettingsjson
    public class GardenContext : DbContext
    {
        public GardenContext(DbContextOptions<GardenContext> options)
            :base (options)
        {

        }
        //this will be a table in our database that willl connect to our database
        public DbSet<Garden> GardenItems {get; set;}
    }
}




//database context
