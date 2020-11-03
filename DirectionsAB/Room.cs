using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectionsAB
{
    [Table(Name ="Rooms")]
    class Room
    {
        [Column(IsPrimaryKey = true, Name = "Id")]
        public int Id { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }
        [Column(Name = "Point1X")]
        public float Point1x { get; set; }
        [Column(Name = "Point2X")]
        public float Point2x { get; set; }
        [Column(Name = "Point1Y")]
        public float Point1y { get; set; }
        [Column(Name = "Point2Y")]
        public float Point2y { get; set; }
    }
}
