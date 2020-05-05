namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node
{
    public static class PascalCompositeNodeTypes
    {
        public static readonly PascalCompositeNodeType Identifier = new PascalCompositeNodeType("PASCAL_IDENTIFIER", 0);

        public static readonly PascalCompositeNodeType VariableDeclaration = new PascalCompositeNodeType("PASCAL_VARIABLE_DECLARATION", 1);
        public static readonly PascalCompositeNodeType Variable = new PascalCompositeNodeType("PASCAL_VARIABLE", 2);

        public static readonly PascalCompositeNodeType Block = new PascalCompositeNodeType("PASCAL_BLOCK", 3);

        public static readonly PascalErrorNodeType Error = new PascalErrorNodeType("PASCAL_ERROR", 4);
    }
}