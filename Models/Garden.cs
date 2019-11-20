namespace GardensApi.Models
{
    //output of json body, the interface and how the database will look
    public class Garden
    {
        public int Id {get; set;}
        public string PlantName {get; set;}
        public string PlantDescription {get; set;}
        public bool Alive {get; set;}
        public bool Indoor {get; set;}
    }
}
