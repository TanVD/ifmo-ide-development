using JetBrains.Diagnostics;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.TreeBuilder;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node
{
    public class PascalErrorNodeType : CompositeNodeWithArgumentType
    {
        public PascalErrorNodeType(string s, int index) : base(s, index)
        {
        }

        public class Message
        {
            public string Text { get; }
            public int Length { get; }

            public Message(string text, int length)
            {
                Length = length;
                Text = text;
            }
        }

        public override CompositeElement Create()
        {
            Assertion.Fail("Can't create PascalErrorNodeType without an argument.");
            return null;
        }

        public override CompositeElement Create(object message)
        {
            var msg = (Message) message;
            return new PascalErrorElement(msg.Text, msg.Length);
        }
    }
}