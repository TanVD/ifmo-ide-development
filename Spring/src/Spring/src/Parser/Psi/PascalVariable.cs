using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi
{
    public class PascalVariable : CompositeElement
    {
        public override NodeType NodeType => PascalCompositeNodeTypes.VariableDeclaration;
        public override PsiLanguageType Language => SpringLanguage.Instance;
    }
}