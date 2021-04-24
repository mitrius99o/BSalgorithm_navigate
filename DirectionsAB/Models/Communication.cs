using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB.Models
{
    
    class Communication
    {
        [Key]
        public int Id { get; set; }
        public int RegionID { get; set; }
        
        public int CommID { get; set; }
    }
}
