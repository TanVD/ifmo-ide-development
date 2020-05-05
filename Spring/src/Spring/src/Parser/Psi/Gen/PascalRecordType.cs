using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalRecordType : PascalAntlrCompositeElement<GPascalParser.RecordTypeContext>
    {
        public PascalRecordType(GPascalParser.RecordTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.RecordType;
    }
}