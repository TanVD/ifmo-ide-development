using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalRelationaloperator : PascalAntlrCompositeElement<GPascalParser.RelationaloperatorContext>
    {
        public PascalRelationaloperator(GPascalParser.RelationaloperatorContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Relationaloperator;
    }
}