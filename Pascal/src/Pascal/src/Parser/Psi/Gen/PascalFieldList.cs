using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalFieldList : PascalAntlrCompositeElement<GPascalParser.FieldListContext>
    {
        public PascalFieldList(GPascalParser.FieldListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.FieldList;
    }
}