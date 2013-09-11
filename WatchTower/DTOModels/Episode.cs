using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace WatchTower.DTOModels
{
    class Episode
    {
        [AutoIncrement] 
        public Int64 Id { get; set; }

        [Required]
        public Int64 SeriesId { get; set; }

        public Series Series { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int SeasonNo { get; set; }
        [Required]
        public int EpisodeNo { get; set; }
        public string FileFullPath { get; set; }
        [Required]
        public DateTime DateAddedToCollection { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }

        public virtual ICollection<ProfileEpisodeRel> ProfileEpisodeRel { get; set; }
    }

}
