using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalRecordType : PascalAntlrCompositeElement<GPascalParser.RecordTypeContext>
    {
        public PascalRecordType(GPascalParser.RecordTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.RecordType;
    }
}