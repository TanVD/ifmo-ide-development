package utils.parser

import java.util.*

object GenerateNodeTypes {
    fun genereate(tokens: SortedSet<String>): List<String> {
        val result = ArrayList<String>()
        for ((index, token) in tokens.withIndex()) {
            result.add("public static readonly PascalAntlrNodeType ${token.capitalize()} = new PascalAntlrNodeType(\"PASCAL_${Utils.split(token).joinToString(separator = "_").toUpperCase()}\", $index);")
        }
        return result;
    }
}