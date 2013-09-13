using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace WatchTower.POCO
{
    class Series
    {
        public Int64 Id { get; set; }

        public string Name { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual ICollection<ProfileSeriesRel> ProfileSeriesRels { get; set; }
    }

}
