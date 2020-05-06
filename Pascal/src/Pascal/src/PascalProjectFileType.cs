using System.Collections.Generic;
using JetBrains.ProjectModel;

namespace JetBrains.ReSharper.Plugins.Pascal
{
    [ProjectFileTypeDefinition(NAME)]
    public class PascalProjectFileType : KnownProjectFileType
    {
        private const string PASCAL_EXTENSION = ".pas";

        private const string NAME = "Pascal";

        public new static PascalProjectFileType Instance { get; private set; }

        private PascalProjectFileType() : base(NAME, "Pascal", new[] {PASCAL_EXTENSION})
        {
        }

        protected PascalProjectFileType(string name) : base(name)
        {
        }

        protected PascalProjectFileType(string name, string presentableName) : base(name, presentableName)
        {
        }

        protected PascalProjectFileType(string name, string presentableName, IEnumerable<string> extensions) : base(
            name,
            presentableName, extensions)
        {
        }
    }
}