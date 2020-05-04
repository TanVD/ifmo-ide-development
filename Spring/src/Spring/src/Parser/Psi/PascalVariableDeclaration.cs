using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi
{
    public class PascalVariableDeclaration: CompositeElement
    {
        public override NodeType NodeType => PascalCompositeNodeTypes.VariableDeclaration;
        public override PsiLanguageType Language => SpringLanguage.Instance;
    }
}