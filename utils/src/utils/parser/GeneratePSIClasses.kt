package utils.parser

import java.io.File
import java.util.*

object GeneratePSIClasses {
    private val path = "/home/tanvd/csc/ide/spring-lang/utils/src/utils/parser/gen"

    fun generate(tokens: SortedSet<String>) {
        File(path).mkdir()
        for (token in tokens) {
            val name = token.capitalize()
            File(File(path), "Pascal${name}.cs").writeText("""
                    using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
                    using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
                    
                    namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen
                    {
                        public class Pascal${name} : PascalAntlrCompositeElement<GPascalParser.${name}Context>
                        {
                            public Pascal${name}(GPascalParser.${name}Context context) : base(context)
                            {
                            }
                    
                            public override NodeType NodeType => PascalNodeTypes.${name};
                        }
                    }
            """.trimIndent())
        }
    }
}