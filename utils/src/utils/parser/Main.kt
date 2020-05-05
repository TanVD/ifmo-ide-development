package utils.parser

class Main

fun main() {
    val regex = Regex("(.*[^=])=(\\d+)")

    var tokens = Main::class.java.getResourceAsStream("rules.tokens").reader().readLines().filter { it.isNotBlank() }.toSortedSet()

    GenerateNodeFactory.generate(tokens)


}
