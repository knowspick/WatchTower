using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTower.DTOModels
{
    class ProfileEpisodeRel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        [Required]
        public Int64 ProfileId { get; set; }
        [Required]
        public Int64 EpisodeId { get; set; }
        [Required]
        public Boolean Played { get; set; }
        [Required]
        public Boolean Watched { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }

        public virtual Episode Episode { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
