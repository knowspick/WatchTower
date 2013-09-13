using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace WatchTower.POCO
{
    class Episode
    {
        [AutoIncrement] 
        public Int64 Id { get; set; }

        [References(typeof(Series))]
        public Int64 SeriesId { get; set; }

        public string Name { get; set; }
        public int SeasonNo { get; set; }
        public int EpisodeNo { get; set; }
        public string FileFullPath { get; set; }
        public DateTime DateAddedToCollection { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual ICollection<ProfileEpisodeRel> ProfileEpisodeRel { get; set; }
    }

}
