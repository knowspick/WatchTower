using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTower.POCO
{
    class ProfileEpisodeRel
    {
        public Int64 Id { get; set; }
        public Int64 ProfileId { get; set; }
        public Int64 EpisodeId { get; set; }
        public Boolean Played { get; set; }
        public Boolean Watched { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual Episode Episode { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
