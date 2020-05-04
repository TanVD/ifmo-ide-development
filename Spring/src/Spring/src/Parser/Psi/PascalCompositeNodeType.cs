using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi
{
    public class PascalCompositeNodeType : CompositeNodeType
    {
        public PascalCompositeNodeType(string s, int index) : base(s, index)
        {
        }

        public override CompositeElement Create()
        {
            if (this == PascalCompositeNodeTypes.Block)
            {
                return new PascalBlock();
            }
            else if (this == PascalCompositeNodeTypes.Variable)
            {
                return new PascalVariable();
            }
            else if (this == PascalCompositeNodeTypes.VariableDeclaration)
            {
                return new PascalVariableDeclaration();
            }

            return null;
        }
    }
}