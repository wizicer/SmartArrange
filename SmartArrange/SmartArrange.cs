namespace IcerSystem.FileArrange
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Abstractions;
    using System.Linq;

    internal class SmartArrange
    {
        private const string DefaultFolderName = "New Folder";
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
            var lst = new List<FileSystemInfoBase>();
            DirectoryInfoBase parentDir = null;
            foreach (var filename in fileNames)
            {
                DirectoryInfoBase tmpParentDir = null;
                if (this.fileSystem.File.Exists(filename))
                {
                    var fi = this.fileSystem.FileInfo.FromFileName(filename);
                    lst.Add(fi);
                    tmpParentDir = fi.Directory;
                }
                else if (this.fileSystem.Directory.Exists(filename))
                {
                    var di = this.fileSystem.DirectoryInfo.FromDirectoryName(filename);
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

            var commonStr = CommonStringExtension.GetCommonSubstring(lst.Select(fsi => fsi.Name.Remove(fsi.Name.Length - fsi.Extension.Length)).ToArray());
            if (string.IsNullOrEmpty(commonStr))
            {
                var newFolderName = DefaultFolderName;
                var count = 0;
                while (this.fileSystem.Directory.Exists(parentDir.FullName + "\\" + newFolderName))
                    newFolderName = DefaultFolderName + (count++).ToString();
                commonStr = newFolderName;
            }

            DirectoryInfoBase newDir;
            var sameNameFSI = lst.SingleOrDefault(fsi => fsi.Name == commonStr);
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

            foreach (var item in lst)
            {
                var newPath = newDir.FullName + "\\" + item.Name;
                MoveToPath(item, newPath);
            }
        }

        private static void MoveToPath(FileSystemInfoBase item, string newPath)
        {
            if (item is DirectoryInfoBase)
            {
                var di = item as DirectoryInfoBase;
                di.MoveTo(newPath);
            }
            else if (item is FileInfoBase)
            {
                var fi = item as FileInfoBase;
                fi.MoveTo(newPath);
            }
        }
    }
}