using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalProcedureDeclaration : PascalAntlrCompositeElement<GPascalParser.ProcedureDeclarationContext>
    {
        public PascalProcedureDeclaration(GPascalParser.ProcedureDeclarationContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ProcedureDeclaration;
    }
}