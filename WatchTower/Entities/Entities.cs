using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WatchTower.Entities
{
    public enum enumLikeStatus { Unrated, Interested, Uninterest };  

    public class Episode
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 EpisodeId      { get; set; }
        [Required]
        public Int64 SeriesId       { get; set; }

        public virtual Series Series { get; set; }

        [Required]
        public string Name          { get; set; }
        [Required]
        public int SeasonNo         { get; set; }
        [Required]
        public int EpisodeNo        { get; set; }
        public string FileFullPath { get; set; }
        [Required]
        public DateTime DateAddedToCollection { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime LastUpdated { get; set; }
    }

    public class Series
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 SeriesId { get; set; }
        [Required]
        public string Name  { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime LastUpdated { get; set; }
    }

    public class Profile
    {
        [Key]
        public Int64 ProfielId { get; set; }
        public string Name   { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
    }

    public class ProfileSeriesRel
    {
        public Int64 ProfileID { get; set; }
        public Int64 SeriesID { get; set; }
        public enumLikeStatus LikeStatus { get; set; } //todo redefine
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
    }

    public class ProfileEpisodeRel
    {
        public Int64 ProfileID { get; set; }
        public Int64 EpisodeId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
    }

    public class WatchTowerEF : DbContext
    {
        public WatchTowerEF()
            : base("Name=WatchTowerDB")
        { }
        
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Series> Series { get; set; }
    }
}
