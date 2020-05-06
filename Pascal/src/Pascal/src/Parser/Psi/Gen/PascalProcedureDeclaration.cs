using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalProcedureDeclaration : PascalAntlrCompositeElement<GPascalParser.ProcedureDeclarationContext>
    {
        public PascalProcedureDeclaration(GPascalParser.ProcedureDeclarationContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ProcedureDeclaration;
    }
}