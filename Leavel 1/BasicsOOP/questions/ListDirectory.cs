using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BasicsOOP.questions
{
    class ListDirectory
    {
        public static List<DirectoryInfo> GetAlbums(List<FileInfo> files)
        {

            List<DirectoryInfo> listDirectoryInfo = new List<DirectoryInfo>();

            foreach(var dir in files)
            {
                if (dir.Extension == ".mp3" || dir.Extension == ".wav")
                {
                    bool flag = false;
                    foreach (var d in listDirectoryInfo)
                    {
                        if (dir.DirectoryName == d.FullName)
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (!flag)
                    {
                        listDirectoryInfo.Add(dir.Directory);
                    }
                }
            }

            return listDirectoryInfo;
        }

    }
}
