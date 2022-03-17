using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB.Models
{
    
    public class Region
    {
        [Key]
        public int RegionId { get; set; }
        public string Name { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        //public string Type { get; set; }
        //public string Description { get; set; }
    }
}
