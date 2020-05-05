using JetBrains.ReSharper.Plugins.Spring.Parser.Gen;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.TreeBuilder;

namespace JetBrains.ReSharper.Plugins.Spring.Parser
{
    public class PascalParserVisitor : PascalGenParserVisitor
    {
        public PascalParserVisitor(PsiBuilder psiBuilder) : base(psiBuilder)
        {
        }

        public override object VisitVariableDeclaration(GPascalParser.VariableDeclarationContext context)
        {
            VisitType(context, PascalNodeTypes.VariableDeclaration);

            return null;
        }

        public override object VisitVariable(GPascalParser.VariableContext context)
        {
            VisitType(context, PascalNodeTypes.Variable);

            return null;
        }

        public override object VisitIdentifier(GPascalParser.IdentifierContext context)
        {
            VisitType(context, PascalNodeTypes.Identifier);

            return null;
        }
        
    }
}