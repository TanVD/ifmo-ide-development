using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalLabelDeclarationPart : PascalAntlrCompositeElement<GPascalParser.LabelDeclarationPartContext>
    {
        public PascalLabelDeclarationPart(GPascalParser.LabelDeclarationPartContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.LabelDeclarationPart;
    }
}