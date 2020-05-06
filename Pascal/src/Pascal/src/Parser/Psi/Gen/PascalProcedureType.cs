using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalProcedureType : PascalAntlrCompositeElement<GPascalParser.ProcedureTypeContext>
    {
        public PascalProcedureType(GPascalParser.ProcedureTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ProcedureType;
    }
}