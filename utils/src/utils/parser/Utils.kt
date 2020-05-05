package utils.parser

object Utils {
    fun split(text: String) = text.split(Regex("(?<!(^|[A-Z]))(?=[A-Z])|(?<!^)(?=[A-Z][a-z])"))
}