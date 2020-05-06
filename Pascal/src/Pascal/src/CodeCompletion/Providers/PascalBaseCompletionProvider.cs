using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.AspectLookupItems.BaseInfrastructure;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.AspectLookupItems.Behaviors;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.AspectLookupItems.Info;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.AspectLookupItems.Matchers;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.AspectLookupItems.Presentations;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.LookupItems;

namespace JetBrains.ReSharper.Plugins.Pascal.CodeCompletion.Providers
{
    public abstract class PascalBaseCompletionProvider : ItemsProviderOfSpecificContext<PascalCodeCompletionContextProvider.PascalCodeCompletionContext>
    {
        protected ILookupItem GetLookupElement(string replace, TextLookupRanges ranges)
        {
            var info = new TextualInfo(replace, replace) {ReplaceText = replace, Ranges = ranges};
            var item = LookupItemFactory.CreateLookupItem(info)
                .WithPresentation(_ => new TextPresentation<TextualInfo>(info))
                .WithBehavior(_ => new TextualBehavior<TextualInfo>(info))
                .WithMatcher(_ => new TextualMatcher<TextualInfo>(info));

            return item;
        }
    }
}