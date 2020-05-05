using System;
using System.Linq;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi
{
    public class PascalVariable : PascalAntlrCompositeElement<GPascalParser.VariableContext>
    {
        public PascalIdentifier Identifier => (PascalIdentifier) this.Children().First(it => it is PascalIdentifier);

        public PascalVariable(GPascalParser.VariableContext context): base(context)
        {
        }

        public override NodeType NodeType => PascalNodeTypes.Variable;
    }
}