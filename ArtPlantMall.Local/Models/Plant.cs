using System;
namespace ArtPlantMall.Local.Models
{
    public class Plant
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int Id { get; internal set; }
    }
}
