using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
{
    public class PascalProcedureAndFunctionDeclarationPart : PascalAntlrCompositeElement<GPascalParser.ProcedureAndFunctionDeclarationPartContext>
    {
        public PascalProcedureAndFunctionDeclarationPart(GPascalParser.ProcedureAndFunctionDeclarationPartContext context) : base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.ProcedureAndFunctionDeclarationPart;
    }
}