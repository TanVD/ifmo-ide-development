using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalRecordVariableList : PascalAntlrCompositeElement<GPascalParser.RecordVariableListContext>
    {
        public PascalRecordVariableList(GPascalParser.RecordVariableListContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.RecordVariableList;
    }
}