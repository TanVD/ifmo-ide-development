using System.Linq;
using JetBrains.Annotations;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.LookupItems;
using JetBrains.ReSharper.Plugins.Pascal.Lexer;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi.Node.Gen;
using JetBrains.ReSharper.Plugins.Pascal.Resolve.Util;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Util;

namespace JetBrains.ReSharper.Plugins.Pascal.CodeCompletion.Providers
{
    [Language(typeof(PascalLanguage))]
    public class PascalVariableCompletionItemsProvider : PascalBaseCompletionProvider
    {
        private bool ShouldBeConsidered([NotNull] ITreeNode node)
        {
            return node.NodeType == PascalTokenTypes.IDENT;
        }
        
        protected override bool IsAvailable(PascalCodeCompletionContextProvider.PascalCodeCompletionContext context)
        {
            if (!base.IsAvailable(context)) return false;

            var node = context.UnterminatedContext.TreeNode;
            if (node == null) return false;

            return ShouldBeConsidered(node);
        }

        protected override bool AddLookupItems(PascalCodeCompletionContextProvider.PascalCodeCompletionContext context, IItemsCollector collector)
        {
            var node = context.UnterminatedContext.TreeNode;
            if (node == null ||  !ShouldBeConsidered(node)) return false;

            var declared = PascalPsiUtil.FindAllAccessibleDeclared(node).ToList();

            if (declared.IsEmpty()) return false;
            
            foreach (var element in declared)
            {
                collector.Add(GetLookupElement(element.ShortName, context.ElementRanges));
            }

            return true;
        }
    }
}