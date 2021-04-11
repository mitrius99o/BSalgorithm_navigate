using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DirectionsAB.Models
{
    class Communication
    {
       public int RegionID { get; set; }
       [Key]
       public int CommID { get; set; }
    }
}
