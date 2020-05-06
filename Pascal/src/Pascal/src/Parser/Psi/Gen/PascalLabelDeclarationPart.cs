using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalLabelDeclarationPart : PascalAntlrCompositeElement<GPascalParser.LabelDeclarationPartContext>
    {
        public PascalLabelDeclarationPart(GPascalParser.LabelDeclarationPartContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.LabelDeclarationPart;
    }
}