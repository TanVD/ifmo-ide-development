using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalConstantDefinition : PascalAntlrCompositeElement<GPascalParser.ConstantDefinitionContext>
    {
        public PascalConstantDefinition(GPascalParser.ConstantDefinitionContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ConstantDefinition;
    }
}