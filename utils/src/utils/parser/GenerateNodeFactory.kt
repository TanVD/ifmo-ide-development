package utils.parser

import java.io.File
import java.util.*

object GenerateNodeFactory {

    private val path = "/home/tanvd/csc/ide/spring-lang/utils/src/utils/parser/gen"

    fun generate(tokens: SortedSet<String>) {
        File(path).mkdir()
        val result = buildString {
            append("""
                using JetBrains.Diagnostics;
                using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
                
                namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node
                {
                    public static class PascalAntlrNodeTypesFactoryGen
                    {
                        public static CompositeElement Create(PascalAntlrNodeType type, object data)
                        {
            """.trimIndent())
            for (token in tokens) {
                val name = token.capitalize()
                append("""
                                if (type == PascalNodeTypes.${name})
                                {
                                    return new Pascal${name}((GPascalParser.${name}Context) data);
                                }
                """.trimIndent())
            }
            append("""
            Assertion.Fail(${'$'}"PascalAntlrNodeType with non-defined Create {type}");
            return null;
        }
    }
}
            """.trimIndent())
        }
        File(File(path), "PascalAntlrNodeTypesFactoryGen.cs").writeText(result)
    }
}