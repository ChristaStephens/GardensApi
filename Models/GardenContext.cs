
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
        //this will be a table in our database that will connect to our database
        //click dbo.gardenitems in sql
        //right click on the above line item and click edit top 200 rows
        //input data
        public DbSet<Garden> GardenItems {get; set;}
    }
}




//database context
