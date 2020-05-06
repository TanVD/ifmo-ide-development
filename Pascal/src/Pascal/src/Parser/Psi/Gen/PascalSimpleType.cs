using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalSimpleType : PascalAntlrCompositeElement<GPascalParser.SimpleTypeContext>
    {
        public PascalSimpleType(GPascalParser.SimpleTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.SimpleType;
    }
}