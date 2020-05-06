using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalSetType : PascalAntlrCompositeElement<GPascalParser.SetTypeContext>
    {
        public PascalSetType(GPascalParser.SetTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.SetType;
    }
}