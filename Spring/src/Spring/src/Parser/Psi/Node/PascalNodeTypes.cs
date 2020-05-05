namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node
{
    public static class PascalNodeTypes
    {
        public static readonly PascalAntlrNodeType Identifier = new PascalAntlrNodeType("PASCAL_IDENTIFIER", 0);

        public static readonly PascalAntlrNodeType VariableDeclaration = new PascalAntlrNodeType("PASCAL_VARIABLE_DECLARATION", 1);
        public static readonly PascalAntlrNodeType Variable = new PascalAntlrNodeType("PASCAL_VARIABLE", 2);

        public static readonly PascalErrorNodeType Error = new PascalErrorNodeType("PASCAL_ERROR", 3);
    }
}