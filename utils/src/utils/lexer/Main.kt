package utils.lexer

class Main

fun main() {
    val regex = Regex("(.*[^=])=(\\d+)")

    val tokens = Main::class.java.getResourceAsStream("pascal.tokens").reader().readLines().filter { it.isNotBlank() }

    val allNames = HashSet<String>()

    for (token in tokens) {
        val match = regex.matchEntire(token)!!
        val (name, id)= match.groups.drop(1).map { it!!.value }.map { it.trim('\'') }
        val nameNormalized = if (name.all { !it.isLetter() }) {
            (name.map { Character.getName(it.toInt()) }.flatMap { it.split(" ", "-") } + "SYM").joinToString(separator = "_")
        } else {
            name
        }
        allNames.add(nameNormalized)
        println("public static SpringTokenType ${nameNormalized} = new SpringTokenType(\"${name}\", ${id});")
    }

    for (name in allNames) {
        println("Register($name);")
    }

}
