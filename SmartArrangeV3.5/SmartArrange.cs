using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace IcerSystem.FileArrange
{
    internal class SmartArrange
    {
        public SmartArrange()
        {

        }

        internal static string Arrange(string[] fileNames)
        {
            //List<string> names = new List<string>();
            List<FileSystemInfo> lst = new List<FileSystemInfo>();
            DirectoryInfo parentDir = null;
            for (int i = 0; i < fileNames.Length; i++)
            {
                DirectoryInfo tmpParentDir = null;
                if (File.Exists(fileNames[i]))
                {
                    FileInfo fi = new FileInfo(fileNames[i]);
                    lst.Add(fi);
                    tmpParentDir = fi.Directory;
                    //names.Add(fi.Name);
                }
                else if (Directory.Exists(fileNames[i]))
                {
                    DirectoryInfo di = new DirectoryInfo(fileNames[i]);
                    lst.Add(di);
                    tmpParentDir = di.Parent;
                    //names.Add(di.Name);
                }
                else
                {
                    return "ERROR: 文件类型不正确！";
                }
                if (parentDir == null)
                {
                    parentDir = tmpParentDir;
                }
                else
                {
                    if (parentDir.FullName != tmpParentDir.FullName)
                    {
                        return "ERROR: 暂不能处理非同一主目录的情况！";
                    }
                }
            }
            //string commonStr = CommonStringExtension.GetCommonSubstring(names.ToArray());           
            string commonStr = CommonStringExtension.GetCommonSubstring(lst.Select(fsi => fsi.Name.Remove(fsi.Name.Length - fsi.Extension.Length)).ToArray());
            if (string.IsNullOrEmpty(commonStr))
            {
                string newFolderName = "New Folder";
                var count = 0;
                while (Directory.Exists(parentDir.FullName + "\\" + newFolderName))
                    newFolderName = "New Folder" + (count++).ToString();
                commonStr = newFolderName;
            }

            DirectoryInfo newDir;
            var sameNameFSI = lst.Where(fsi => fsi.Name == commonStr).SingleOrDefault();
            if (sameNameFSI != null)
            {
                var pathName = sameNameFSI.FullName;
                if (pathName.EndsWith("\\")) pathName = pathName.Remove(pathName.Length - 1);
                MoveToPath(sameNameFSI, pathName + ".HGYYFGHFDC");
                newDir = parentDir.CreateSubdirectory(commonStr);
                MoveToPath(sameNameFSI, newDir.FullName + "\\" + commonStr);
                lst.Remove(sameNameFSI);
            }
            else
            {
                newDir = parentDir.CreateSubdirectory(commonStr);
            }
            foreach (FileSystemInfo item in lst)
            {
                var newPath = newDir.FullName + "\\" + item.Name;
                MoveToPath(item, newPath);
            }
            return "OK: 完成";
        }

        private static void MoveToPath(FileSystemInfo item, string newPath)
        {
            if (item is DirectoryInfo)
            {
                DirectoryInfo di = item as DirectoryInfo;
                di.MoveTo(newPath);
            }
            else if (item is FileInfo)
            {
                FileInfo fi = item as FileInfo;
                fi.MoveTo(newPath);
            }
        }
    }
}
