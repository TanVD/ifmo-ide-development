using System.Collections.Generic;
using JetBrains.Annotations;
using JetBrains.ReSharper.Plugins.Pascal.Lexer;
using JetBrains.ReSharper.Plugins.Pascal.Parser;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2;
using JetBrains.ReSharper.Psi.Impl;
using JetBrains.ReSharper.Psi.Modules;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using JetBrains.Util;

namespace JetBrains.ReSharper.Plugins.Pascal
{
    [Language(typeof(PascalLanguage))]
    class PascalLanguageService : LanguageService
    {
        public PascalLanguageService([NotNull] PsiLanguageType psiLanguageType,
            [NotNull] IConstantValueService constantValueService) : base(psiLanguageType, constantValueService)
        {
        }

        public override ILexerFactory GetPrimaryLexerFactory()
        {
            return new LexerFactory();
        }

        public override ILexer CreateFilteringLexer(ILexer lexer)
        {
            return lexer;
        }
        
        public override IParser CreateParser(ILexer lexer, IPsiModule module, IPsiSourceFile sourceFile)
        {
            return new PascalParser(lexer);
        }

        public override IEnumerable<ITypeDeclaration> FindTypeDeclarations(IFile file)
        {
            return EmptyList<ITypeDeclaration>.Instance;
        }

        public override ILanguageCacheProvider CacheProvider => null;
        public override bool IsCaseSensitive => false;
        public override bool SupportTypeMemberCache => false;
        public override ITypePresenter TypePresenter => CLRTypePresenter.Instance;

        internal class LexerFactory : ILexerFactory
        {
            public ILexer CreateLexer(IBuffer buffer)
            {
                return new PascalLexer(buffer);
            }
        }
    }
}