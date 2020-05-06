using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Gen
{
    public class PascalProcedureOrFunctionDeclaration : PascalAntlrCompositeElement<GPascalParser.ProcedureOrFunctionDeclarationContext>
    {
        public PascalProcedureOrFunctionDeclaration(GPascalParser.ProcedureOrFunctionDeclarationContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ProcedureOrFunctionDeclaration;
    }
}