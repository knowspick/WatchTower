using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace WatchTower.POCO
{
    class ProfileSeriesRel
    {
        public Int64 Id { get; set; }

        public Int64 ProfileId { get; set; }
        public Int64 SeriesId { get; set; }
        public Boolean WantToWatch { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual Series Series { get; set; }
        public virtual Profile Profile { get; set; }
    }

}
