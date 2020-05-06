using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalRecordSection : PascalAntlrCompositeElement<GPascalParser.RecordSectionContext>
    {
        public PascalRecordSection(GPascalParser.RecordSectionContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.RecordSection;
    }
}