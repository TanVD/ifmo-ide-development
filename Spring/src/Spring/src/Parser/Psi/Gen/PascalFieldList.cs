using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalFieldList : PascalAntlrCompositeElement<GPascalParser.FieldListContext>
    {
        public PascalFieldList(GPascalParser.FieldListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FieldList;
    }
}