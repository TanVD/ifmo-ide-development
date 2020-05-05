using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalRelationaloperator : PascalAntlrCompositeElement<GPascalParser.RelationaloperatorContext>
    {
        public PascalRelationaloperator(GPascalParser.RelationaloperatorContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Relationaloperator;
    }
}