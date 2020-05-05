using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalBaseType : PascalAntlrCompositeElement<GPascalParser.BaseTypeContext>
    {
        public PascalBaseType(GPascalParser.BaseTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.BaseType;
    }
}