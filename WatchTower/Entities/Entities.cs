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
    public class Episode
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        [Required]
        public Int64 SeriesId       { get; set; }

        //public virtual Series Series { get; set; }
        public Series Series { get; set; }

        [Required]
        public string Name          { get; set; }
        [Required]
        public int SeasonNo         { get; set; }
        [Required]
        public int EpisodeNo        { get; set; }
        public string FileFullPath  { get; set; }
        [Required]
        public DateTime DateAddedToCollection { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
    }

    [Table("Serieses")]
    public class Series
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        [Required]
        public string Name  { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
        //public virtual ICollection<ProfileSeriesRel> ProfileSeriesRels { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
    }

    public class test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        public string name { get; set; }
    }


    public class Profile
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        [Required]
        public string Name   { get; set; }
        //public virtual ICollection<ProfileSeriesRel> ProfileSeriesRels { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
    }

    public class ProfileSeriesRel
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        [Required]
        public Int64 ProfileId { get; set; }
        [Required]
        public Int64 SeriesId { get; set; }
        [Required]
        public Boolean WantToWatch { get ; set; }

        //public virtual Profile Profile { get; set; }
        //public virtual Series Series { get; set; }
        
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime DateCreated { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public DateTime LastUpdated { get; set; }        
    }

    public class ProfileEpisodeRel
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        [Required]
        public Int64 ProfileId { get; set; }
        [Required]
        public Int64 EpisodeId { get; set; }
        [Required]
        public Boolean Watched { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }
    }

    public class WatchTowerEF : DbContext
    {
        public WatchTowerEF()
            : base("Name=WatchTowerDB")
        { }
        
        public DbSet<Episode> Episodes                      { get; set; }
        public DbSet<Series> Serieses                       { get; set; }
        public DbSet<Profile> Profiles                      { get; set; }
        public DbSet<ProfileSeriesRel> ProfileSeriesRels    { get; set; }
        public DbSet<ProfileEpisodeRel> ProfileEpisodeRels  { get; set; }

        public DbSet<test> tests { get; set; }
    }
}
