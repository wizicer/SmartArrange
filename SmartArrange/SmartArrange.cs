namespace IcerSystem.FileArrange
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Abstractions;
    using System.Linq;

    internal class SmartArrange
    {
        private readonly IFileSystem fileSystem;

        public SmartArrange(IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }

        public SmartArrange()
            : this(new FileSystem())
        {
        }

        internal void Arrange(string[] fileNames)
        {
            List<FileSystemInfo> lst = new List<FileSystemInfo>();
            DirectoryInfo parentDir = null;
            for (int i = 0; i < fileNames.Length; i++)
            {
                var filename = fileNames[i];
                DirectoryInfo tmpParentDir = null;
                if (this.fileSystem.File.Exists(filename))
                {
                    FileInfo fi = new FileInfo(filename);
                    lst.Add(fi);
                    tmpParentDir = fi.Directory;
                }
                else if (this.fileSystem.Directory.Exists(filename))
                {
                    DirectoryInfo di = new DirectoryInfo(filename);
                    lst.Add(di);
                    tmpParentDir = di.Parent;
                }
                else
                {
                    throw new FileNotFoundException("file or directory not found.", filename);
                }

                if (parentDir == null)
                {
                    parentDir = tmpParentDir;
                }
                else
                {
                    if (parentDir.FullName != tmpParentDir.FullName)
                    {
                        throw new NotSupportedException("all files or folder must be in one same parent folder.");
                    }
                }
            }

            string commonStr = CommonStringExtension.GetCommonSubstring(lst.Select(fsi => fsi.Name.Remove(fsi.Name.Length - fsi.Extension.Length)).ToArray());
            if (string.IsNullOrEmpty(commonStr))
            {
                string newFolderName = "New Folder";
                var count = 0;
                while (this.fileSystem.Directory.Exists(parentDir.FullName + "\\" + newFolderName))
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