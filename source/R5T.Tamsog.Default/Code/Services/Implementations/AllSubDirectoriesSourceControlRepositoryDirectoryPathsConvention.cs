using System;
using System.Collections.Generic;
using System.IO;

using R5T.Tamsog.Types;


namespace R5T.Tamsog.Default.Code.Services.Implementations
{
    public class AllSubDirectoriesSourceControlRepositoryDirectoryPathsConvention : ISourceControlRepositoryDirectoryPathsConvention
    {
        public IEnumerable<SourceControlRepositoryDirectoryPath> GetSourceControlRepositoryDirectoryPaths(SourceControlUserDirectoryPath sourceControlUserDirectoryPath)
        {
            foreach (var subDirectoryPath in Directory.EnumerateDirectories(sourceControlUserDirectoryPath.Value))
            {
                var sourceControlRepositoryDirectoryPath = new SourceControlRepositoryDirectoryPath(subDirectoryPath);
                yield return sourceControlRepositoryDirectoryPath;
            }
        }
    }
}
