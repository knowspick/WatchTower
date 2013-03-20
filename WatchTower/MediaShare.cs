using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WatchTower
{
    class ShareMediaFunctions
    {       
    /*    private long SizeOfFolder(string AFolderPath)
        {
            long folderSize = 0;
            foreach (string file in Directory.GetFiles(AFolderPath))
            {
                if (File.Exists(file))
                {
                    FileInfo finfo = new FileInfo(file);
                    folderSize += finfo.Length;
                }
            }
            return folderSize;
        }

        private void CopyFolder(string TargetFolder, string DesFolder)
        {
            //create folder in not exist
            Directory.CreateDirectory(DesFolder);
            foreach (string file in Directory.GetFiles(TargetFolder))
            {
                if (File.Exists(file))
                {
                    FileInfo fi = new FileInfo(file);
                    fi.CopyTo(DesFolder + "\\" + fi.Name);
                }
            }
        }

        public void ShareMedia(List<MediaItem> MediaList)
        {
            List<MediaItem> ShareList = new List<MediaItem>();
            List<MediaItem> temp = new List<MediaItem>();
            List<EpisodeItem> temp2 = new List<EpisodeItem>();
            new MediaFunctions().LoadMediaFromFolder(
                Properties.Settings.Default.ShareMoviePath, Properties.Settings.Default.ShareEpisodePath, ref temp, ref temp2, ref ShareList);
            temp = null;
            temp2 = null;

            //copy the lastes stuff from media to share
            MediaList.Sort((x, y) => y.DateAdded.CompareTo(x.DateAdded)); //sort decending
            ShareList.Sort((x, y) => y.DateAdded.CompareTo(x.DateAdded)); //sort decending

            //get the index of the last item in medialist that need coping
            int IndexOfLastCopyItem = 0;
            if (ShareList.Count > 0)
                IndexOfLastCopyItem = MediaList.FindIndex(x => x.Name == ShareList[0].Name) - 1;
            else
                IndexOfLastCopyItem = MediaList.Count - 1;

            for (int i = IndexOfLastCopyItem; 0 <= i; i--) //start with oldest item
            {
                MediaItem mi = MediaList[i];

                //make sure it not in share
                if (ShareList.FindIndex(x => x.Name == mi.Name) > -1)
                    continue;

                //check diskspace
                string drive = Path.GetPathRoot(Properties.Settings.Default.ShareEpisodePath);

                DriveInfo di = new DriveInfo(drive);
                long SpaceRequired = 0;
                if (mi.Type == MediaType.Episode)
                {
                    FileInfo fi = new FileInfo(mi.FullPath);
                    SpaceRequired = fi.Length;
                }
                else
                {
                    SpaceRequired = SizeOfFolder(mi.FullPath);
                }

                while (di.AvailableFreeSpace < SpaceRequired)
                {
                    if (ShareList.Count == 0)
                        return; //there nothing left to delete, thus there no more space to copy files

                    MediaItem DeleteItem = ShareList[ShareList.Count - 1]; //delete the oldest file in share
                    if (DeleteItem.Type == MediaType.Episode)
                        File.Delete(DeleteItem.FullPath);
                    else
                        Directory.Delete(DeleteItem.FullPath, true);
                    ShareList.Remove(DeleteItem);
                    di = new DriveInfo(drive); //refreash drive info
                }

                //ok now do the copy
                string NewPath;
                if (mi.Type == MediaType.Episode)
                {
                    NewPath = mi.FullPath.Replace(Properties.Settings.Default.EpisodePath, Properties.Settings.Default.ShareEpisodePath);
                    Directory.CreateDirectory(new FileInfo(NewPath).DirectoryName);
                    new FileInfo(mi.FullPath).CopyTo(NewPath);
                }
                else
                {
                    NewPath = mi.FullPath.Replace(Properties.Settings.Default.MoviePath, Properties.Settings.Default.ShareMoviePath);
                    CopyFolder(mi.FullPath, NewPath);
                }

            }


        } */

    } 
}