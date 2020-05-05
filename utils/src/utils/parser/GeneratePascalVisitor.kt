package utils.parser

import java.io.File
import java.util.*

object GeneratePascalVisitor {
    private val path = "/home/tanvd/csc/ide/spring-lang/utils/src/utils/parser/gen"

    fun generate(tokens: SortedSet<String>) {
        File(path).mkdir()
        val result = buildString {
            append("""
                using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
                using JetBrains.ReSharper.Psi.TreeBuilder;
                
                namespace JetBrains.ReSharper.Plugins.Spring.Parser.Gen
                {
                    public class PascalGenParserVisitor : PascalBaseParserVisitor
                    {
                        public PascalGenParserVisitor(PsiBuilder psiBuilder) : base(psiBuilder)
                        {
                        }
            """.trimIndent())
            for (token in tokens) {
                val name = token.capitalize()
                append("""
                            public override object Visit${name}(GPascalParser.${name}Context context)
                            {
                                VisitType(context, PascalNodeTypes.${name});
                                return null;
                            }
                """.trimIndent())
            }
            append("""
    }                
}
            """.trimIndent())
        }
        File(File(path), "PascalGenParserVisitor.cs").writeText(result)
    }
}