using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalProcedureStatement : PascalAntlrCompositeElement<GPascalParser.ProcedureStatementContext>
    {
        public PascalProcedureStatement(GPascalParser.ProcedureStatementContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ProcedureStatement;
    }
}