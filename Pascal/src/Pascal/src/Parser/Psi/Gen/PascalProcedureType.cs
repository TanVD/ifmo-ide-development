using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalProcedureType : PascalAntlrCompositeElement<GPascalParser.ProcedureTypeContext>
    {
        public PascalProcedureType(GPascalParser.ProcedureTypeContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ProcedureType;
    }
}