using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalType : PascalAntlrCompositeElement<GPascalParser.TypeContext>
    {
        public PascalType(GPascalParser.TypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Type;
    }
}