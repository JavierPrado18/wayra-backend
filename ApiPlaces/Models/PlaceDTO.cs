using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPlaces.Models
{
    public class PlaceDTO
    {
        public int Id { get; set; }
        public required string ImageUrl { get; set; }
        public required string Title { get; set; }
        public int IdCategory { get; set; }
    }
}