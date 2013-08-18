using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTower.Entities
{
    public static class EntityExtensions
    {
        public static void SetWatched(this Episode episode,
            List<Profile> selectedProfiles, Boolean watched) {
            
            foreach (Profile profile in selectedProfiles)
            {
                ProfileEpisodeRel EpsRel = episode.ProfileEpisodeRel.SingleOrDefault<ProfileEpisodeRel>(
                    per => per.Profile == profile
                );
                if (EpsRel == null) {
                    EpsRel = new ProfileEpisodeRel {
                        Profile = profile,
                        Episode = episode                        
                    };
                    episode.ProfileEpisodeRel.Add(EpsRel);
                }
                EpsRel.Watched = watched;
            }
        }

        public static void SetPlayed(this Episode episode,
            List<Profile> selectedProfiles, Boolean played)
        {

            foreach (Profile profile in selectedProfiles)
            {
                ProfileEpisodeRel EpsRel = episode.ProfileEpisodeRel.SingleOrDefault<ProfileEpisodeRel>(
                    per => per.Profile == profile);
                if (EpsRel == null)
                {
                    EpsRel = new ProfileEpisodeRel
                    {
                        Profile = profile,
                        Episode = episode
                    };
                    episode.ProfileEpisodeRel.Add(EpsRel);
                }
                EpsRel.Played = played;
            }
        }

        public static Boolean GetPlayed(this Episode episode, List<Profile> selectedProfiles)
        {
            foreach (Profile profile in selectedProfiles)
            {
                ProfileEpisodeRel EpsRel = episode.ProfileEpisodeRel.SingleOrDefault<ProfileEpisodeRel>(
                    per => per.Profile == profile);
                if ((EpsRel != null) && (EpsRel.Played))
                {
                    return true;                        
                }
            }
            return false;
        }

        public static void SetRating (this Series series,
            List<Profile> selectedProfiles, Boolean wantToWatch) {

                foreach (Profile profile in selectedProfiles) {
                ProfileSeriesRel SeriesRel = series.ProfileSeriesRels.SingleOrDefault<ProfileSeriesRel>(
                    psr => psr.Profile == profile
                );
                if (SeriesRel == null) {
                    SeriesRel = (new ProfileSeriesRel {
                        Profile = profile,
                        Series = series
                    });
                    series.ProfileSeriesRels.Add(SeriesRel);
                }
                SeriesRel.WantToWatch = wantToWatch;
            }
        }
    }
}
