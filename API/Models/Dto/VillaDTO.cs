using System.ComponentModel.DataAnnotations;

namespace API.Models.Dto
{
    public class VillaDTO
    {
       
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Occupancy {  get; set; } // udaljenost
        public int Sqft {  get; set; } //kvadrati
        public string ImageUrl { get; set; }
        public string Amenity { get; set; } //comfort
    }
}
