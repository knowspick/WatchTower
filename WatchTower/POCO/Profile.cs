using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTower.POCO
{
    class Profile
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual ICollection<ProfileEpisodeRel> ProfileEpisodeRel { get; set; }
        public virtual ICollection<ProfileSeriesRel> ProfileSeriesRel { get; set; }
    }
}
