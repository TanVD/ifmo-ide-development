using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalConstantDefinitionPart : PascalAntlrCompositeElement<GPascalParser.ConstantDefinitionPartContext>
    {
        public PascalConstantDefinitionPart(GPascalParser.ConstantDefinitionPartContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ConstantDefinitionPart;
    }
}