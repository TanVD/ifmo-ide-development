using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalSetType : PascalAntlrCompositeElement<GPascalParser.SetTypeContext>
    {
        public PascalSetType(GPascalParser.SetTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.SetType;
    }
}