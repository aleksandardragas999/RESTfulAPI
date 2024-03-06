﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //automatically manages  id
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details {  get; set; }
        public double Rate {  get; set; }
        public int Sqft {  get; set; }
        public int Occupancy {  get; set; }
        public string ImageUrl {  get; set; }
        public string Amenity {  get; set; } //comfort
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } 
    }
}
