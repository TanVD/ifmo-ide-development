using JetBrains.Diagnostics;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.TreeBuilder;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node
{
    public class PascalAntlrNodeType : CompositeNodeWithArgumentType
    {
        public PascalAntlrNodeType(string s, int index) : base(s, index)
        {
        }

        public override CompositeElement Create()
        {
            Assertion.Fail("Can't create PascalAntlrNodeType without an argument.");
            return null;
        }

        public override CompositeElement Create(object message)
        {
            if (this == PascalNodeTypes.Variable)
            {
                return new PascalVariable((GPascalParser.VariableContext) message);
            }
            else if (this == PascalNodeTypes.VariableDeclaration)
            {
                return new PascalVariableDeclaration((GPascalParser.VariableDeclarationContext) message);
            }
            else if (this == PascalNodeTypes.Identifier)
            {
                return new PascalIdentifier((GPascalParser.IdentifierContext) message);
            }
            
            Assertion.Fail($"PascalAntlrNodeType with non-defined Create {this}");
            return null;
        }
    }
}