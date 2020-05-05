using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalCaseListElement : PascalAntlrCompositeElement<GPascalParser.CaseListElementContext>
    {
        public PascalCaseListElement(GPascalParser.CaseListElementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.CaseListElement;
    }
}