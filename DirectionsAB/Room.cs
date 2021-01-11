using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB
{
    [Table(Name = "Rooms")]
    public class Room
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "Id")]
        public int Id { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }
        [Column(Name = "X")]
        public float X { get; set; }
        [Column(Name = "Y")]
        public float Point1y { get; set; }
    } 
}
