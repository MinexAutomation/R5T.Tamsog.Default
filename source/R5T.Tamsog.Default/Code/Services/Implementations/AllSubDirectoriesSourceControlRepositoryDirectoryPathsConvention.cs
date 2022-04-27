using System;
using System.Collections.Generic;
using System.IO;

using R5T.Tamsog.Types;using R5T.T0064;


namespace R5T.Tamsog.Default
{[ServiceImplementationMarker]
    public class AllSubDirectoriesSourceControlRepositoryDirectoryPathsConvention : ISourceControlRepositoryDirectoryPathsConvention,IServiceImplementation
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
