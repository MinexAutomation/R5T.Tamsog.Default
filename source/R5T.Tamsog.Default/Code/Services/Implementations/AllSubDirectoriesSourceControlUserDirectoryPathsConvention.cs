using System;
using System.Collections.Generic;
using System.IO;

using R5T.Tamsog.Types;


namespace R5T.Tamsog.Default
{
    public class AllSubDirectoriesSourceControlUserDirectoryPathsConvention : ISourceControlUserDirectoryPathsConvention
    {
        public IEnumerable<SourceControlUserDirectoryPath> GetSourceControlUserDirectoryPaths(SourceControlRootDirectoryPath sourceControlRootDirectoryPath)
        {
            foreach (var subDirectoryPath in Directory.EnumerateDirectories(sourceControlRootDirectoryPath.Value))
            {
                var sourceControlUserDirectoryPath = new SourceControlUserDirectoryPath(subDirectoryPath);
                yield return sourceControlUserDirectoryPath;
            }
        }
    }
}
