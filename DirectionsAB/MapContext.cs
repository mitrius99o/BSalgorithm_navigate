using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DirectionsAB.Models;


namespace DirectionsAB
{
    class MapContext: DbContext
    {
        public MapContext():base("MapDB")
        {
        }

        //collections DBSET with regions with its communications
        public DbSet<Region> Regions { get; set; }
        public DbSet<Communication> Communications { get; set; }
    }
}
