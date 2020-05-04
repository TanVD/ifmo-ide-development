using JetBrains.ReSharper.Plugins.Spring.Lexer;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser
{
    class PascalCompositeNodeType : CompositeNodeType
    {
        public PascalCompositeNodeType(string s, int index) : base(s, index)
        {
        }

        public static readonly PascalCompositeNodeType BLOCK = new PascalCompositeNodeType("Spring_BLOCK", 0);
        public static readonly PascalCompositeNodeType OTHER = new PascalCompositeNodeType("Spring_OTHER", 1);

        public override CompositeElement Create()
        {
            if (this == BLOCK)
                return new SpringBlock();
            else
                return new SpringOther();
        }
    }
}