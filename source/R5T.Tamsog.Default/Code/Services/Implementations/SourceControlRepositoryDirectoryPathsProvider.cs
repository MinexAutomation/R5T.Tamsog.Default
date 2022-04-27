using System;
using System.Collections.Generic;
using System.Linq;

using R5T.Tamsog.Types;using R5T.T0064;


namespace R5T.Tamsog.Default
{[ServiceImplementationMarker]
    public class SourceControlRepositoryDirectoryPathsProvider : ISourceControlRepositoryDirectoryPathsProvider,IServiceImplementation
    {
        private ISourceControlUserDirectoryPathsProvider SourceControlUserDirectoryPathsProvider { get; }
        private ISourceControlRepositoryDirectoryPathsConvention SourceControlRepositoryDirectoryPathsConvention { get; }


        public SourceControlRepositoryDirectoryPathsProvider(
            ISourceControlUserDirectoryPathsProvider sourceControlUserDirectoryPathsProvider,
            ISourceControlRepositoryDirectoryPathsConvention sourceControlRepositoryDirectoryPathsConvention)
        {
            this.SourceControlUserDirectoryPathsProvider = sourceControlUserDirectoryPathsProvider;
            this.SourceControlRepositoryDirectoryPathsConvention = sourceControlRepositoryDirectoryPathsConvention;
        }

        public IEnumerable<SourceControlRepositoryDirectoryPath> GetSourceControlRepositoryDirectoryPaths()
        {
            var sourceControlRepositoryDirectoryPaths = this.SourceControlUserDirectoryPathsProvider.GetSourceControlUserDirectoryPaths()
                .SelectMany(sourceControlUserDirectoryPath => this.SourceControlRepositoryDirectoryPathsConvention.GetSourceControlRepositoryDirectoryPaths(sourceControlUserDirectoryPath));

            return sourceControlRepositoryDirectoryPaths;
        }
    }
}
