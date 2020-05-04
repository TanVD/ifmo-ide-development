namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi
{
    public static class PascalCompositeNodeTypes
    {
        public static readonly PascalCompositeNodeType VariableDeclaration = new PascalCompositeNodeType("PASCAL_VARIABLE_DECLARATION", 0);
        public static readonly PascalCompositeNodeType Variable = new PascalCompositeNodeType("PASCAL_VARIABLE", 1);

        public static readonly PascalCompositeNodeType Block = new PascalCompositeNodeType("PASCAL_BLOCK", 2);
    }
}