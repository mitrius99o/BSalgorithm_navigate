using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB.Models
{
    class Communication
    {

        public int RegionID { get; set; }
        [Key]
        public int CommID { get; set; }
    }
}
