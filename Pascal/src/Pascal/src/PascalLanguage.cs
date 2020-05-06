using JetBrains.Annotations;
using JetBrains.ReSharper.Psi;

namespace JetBrains.ReSharper.Plugins.Spring
{
    [LanguageDefinition(NAME)]
    public class PascalLanguage : KnownLanguage
    {
        private const string NAME = "Pascal";

        public static PascalLanguage Instance { get; private set; }

        private PascalLanguage() : base(NAME, NAME)
        {
        }

        protected PascalLanguage([NotNull] string name) : base(name)
        {
        }

        protected PascalLanguage([NotNull] string name, [NotNull] string presentableName) : base(name, presentableName)
        {
        }
    }
}