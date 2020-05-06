using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.AspectLookupItems.BaseInfrastructure;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.AspectLookupItems.Behaviors;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.AspectLookupItems.Info;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.AspectLookupItems.Matchers;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.AspectLookupItems.Presentations;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.LookupItems;
using JetBrains.ReSharper.Plugins.Pascal.Utils;
using JetBrains.ReSharper.Psi;

namespace JetBrains.ReSharper.Plugins.Pascal.CodeCompletion
{
    [Language(typeof(PascalLanguage))]
    public class PascalCompletionItemsProvider: ItemsProviderOfSpecificContext<PascalCodeCompletionContextProvider.PascalCodeCompletionContext>
    {
        public PascalCompletionItemsProvider()
        {
            PLogger.Info("PascalCompletionItemsProvider WAS CREATED");
        }

        public override CompletionMode SupportedCompletionMode
        {
            get
            {
                PLogger.Info("Someone is asking for CompletionMode");
                return CompletionMode.All;
            }
        }

        protected override bool IsAvailable(PascalCodeCompletionContextProvider.PascalCodeCompletionContext context)
        {
            PLogger.Info("Someone asking PascalCompletionItemsProvider if it is available");
            if (!base.IsAvailable(context)) return false;

            var node = context.UnterminatedContext.TreeNode;
            if (node == null) return false;

            return true;
        }

        protected override bool AddLookupItems(PascalCodeCompletionContextProvider.PascalCodeCompletionContext context, IItemsCollector collector)
        {
            PLogger.Info("Someone asking PascalCompletionItemsProvider to AddLookupItems");
            var info = new TextualInfo("abcd", "abcd");
            var item = LookupItemFactory.CreateLookupItem(info)
                .WithPresentation(_ => new TextPresentation<TextualInfo>(info))
                .WithBehavior(_ => new TextualBehavior<TextualInfo>(info))
                .WithMatcher(_ => new TextualMatcher<TextualInfo>(info));
            collector.Add(item);
            return base.AddLookupItems(context, collector);
        }
    }
}