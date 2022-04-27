using System;
using System.Collections.Generic;
using System.IO;

using R5T.Tamsog.Types;using R5T.T0064;


namespace R5T.Tamsog.Default
{[ServiceImplementationMarker]
    public class AllSubDirectoriesSourceControlUserDirectoryPathsConvention : ISourceControlUserDirectoryPathsConvention,IServiceImplementation
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
