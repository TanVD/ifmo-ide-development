using System;
using JetBrains.ReSharper.Feature.Services.CodeCompletion;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure;
using JetBrains.ReSharper.Feature.Services.Util;
using JetBrains.ReSharper.Plugins.Pascal.Parser.Psi;
using JetBrains.ReSharper.Plugins.Pascal.Utils;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.Pascal.CodeCompletion
{
    [IntellisensePart]
    public class PascalCodeCompletionContextProvider : CodeCompletionContextProviderBase
    {
        public override bool IsApplicable(CodeCompletionContext context)
        {
            PLogger.Info($"Someone asking if PascalCompletionContextProvider is Applicable, answer {context.File is PascalFile}");
            return context.File is PascalFile;
        }
        
        public override ISpecificCodeCompletionContext GetCompletionContext(CodeCompletionContext context)
        {
            PLogger.Info("Someone asking PascalCompletionContextProvider for Context");
            var file = context.File as PascalFile;
            if (file == null) return null;

            var reparsedContext = new PascalReparsedCompletionContext(file, context.SelectedTreeRange, "aaa");

            reparsedContext.Init();
            return GetSpecificContext(context, reparsedContext);
        }

        public static ISpecificCodeCompletionContext GetSpecificContext(
            CodeCompletionContext context, ReparsedCodeCompletionContext unterminatedContext, PsiLanguageType customLanguageType = null)
        {
            var elementToComplete = unterminatedContext.TreeNode;
            if (elementToComplete == null) return null;

            var elementRange = elementToComplete.GetTreeTextRange();
            var elementDocumentRange = unterminatedContext.ToDocumentRange(elementRange);

            var referenceToComplete = unterminatedContext.Reference;
            var referenceRange = referenceToComplete?.GetTreeTextRange() ?? elementRange;
            var referenceDocumentRange = unterminatedContext.ToDocumentRange(referenceRange);
            if (!referenceDocumentRange.IsValid())
                return null;

            if (!referenceDocumentRange.Contains(context.EffectiveCaretDocumentOffset)) return null;
            if (!elementDocumentRange.Contains(context.EffectiveCaretDocumentOffset)) return null;

            var language = customLanguageType ?? PascalLanguage.Instance;
            if (language == null)
                return null;

            var referenceRanges = GetTextLookupRanges(context, referenceDocumentRange);
            var elementRanges = GetTextLookupRanges(context, elementDocumentRange);
            return new PascalCodeCompletionContext(context, referenceRanges, elementRanges, unterminatedContext);
        }

        public class PascalReparsedCompletionContext : ReparsedCodeCompletionContext
        {
            public PascalReparsedCompletionContext(IFile file, TreeTextRange selectedTreeRange, string placeholder) : base(file, selectedTreeRange, placeholder)
            {
            }

            protected override IReparseContext GetReparseContext(IFile file, TreeTextRange range)
            {
                return new TrivialReparseContext(file, range);
            }
        }

        public class PascalCodeCompletionContext : SpecificCodeCompletionContext
        {
            public PascalCodeCompletionContext(
                CodeCompletionContext context,
                TextLookupRanges referenceRanges,
                TextLookupRanges elementRanges,
                ReparsedCodeCompletionContext unterminatedContext
            ) : base(context)
            {
                ElementRanges = elementRanges;
                ReferenceRanges = referenceRanges;
                UnterminatedContext = unterminatedContext;
            }

            public override PsiLanguageType Language => PascalLanguage.Instance;

            public TextLookupRanges ElementRanges { get; set; }
            public TextLookupRanges ReferenceRanges { get; set; }
            public ReparsedCodeCompletionContext UnterminatedContext { get; set; }

            public override string ContextId => GetType().Name;
        }
    }
}