using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi
{
    public class PascalFile : FileElementBase
    {
        public override NodeType NodeType => PascalNodeTypes.File;

        public override PsiLanguageType Language => PascalLanguage.Instance;
    }
}