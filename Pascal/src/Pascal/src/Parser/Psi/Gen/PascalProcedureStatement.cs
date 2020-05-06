using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalProcedureStatement : PascalAntlrCompositeElement<GPascalParser.ProcedureStatementContext>
    {
        public PascalProcedureStatement(GPascalParser.ProcedureStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ProcedureStatement;
    }
}