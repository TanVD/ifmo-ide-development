using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi
{
    public class PascalFile : FileElementBase
    {
        public override NodeType NodeType => PascalNodeTypes.File;

        public override PsiLanguageType Language => PascalLanguage.Instance;
    }
}