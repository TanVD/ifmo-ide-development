using System.Collections.Generic;
using JetBrains.Util.Collections;

namespace JetBrains.ReSharper.Plugins.Pascal.Lexer
{
    public static class PascalTokenTypes
    {
        private static readonly HashMap<int, PascalTokenType> ConvertTo = new HashMap<int, PascalTokenType>();

        public static PascalTokenType Convert(int index)
        {
            return !ConvertTo.ContainsKey(index) ? null : ConvertTo[index];
        }

        public static PascalTokenType AND = new PascalTokenType("AND", 1);
        public static PascalTokenType ARRAY = new PascalTokenType("ARRAY", 2);
        public static PascalTokenType BEGIN = new PascalTokenType("BEGIN", 3);
        public static PascalTokenType BOOLEAN = new PascalTokenType("BOOLEAN", 4);
        public static PascalTokenType CASE = new PascalTokenType("CASE", 5);
        public static PascalTokenType CHAR = new PascalTokenType("CHAR", 6);
        public static PascalTokenType CHR = new PascalTokenType("CHR", 7);
        public static PascalTokenType CONST = new PascalTokenType("CONST", 8);
        public static PascalTokenType DIV = new PascalTokenType("DIV", 9);
        public static PascalTokenType DO = new PascalTokenType("DO", 10);
        public static PascalTokenType DOWNTO = new PascalTokenType("DOWNTO", 11);
        public static PascalTokenType ELSE = new PascalTokenType("ELSE", 12);
        public static PascalTokenType END = new PascalTokenType("END", 13);
        public static PascalTokenType FILE = new PascalTokenType("FILE", 14);
        public static PascalTokenType FOR = new PascalTokenType("FOR", 15);
        public static PascalTokenType FUNCTION = new PascalTokenType("FUNCTION", 16);
        public static PascalTokenType GOTO = new PascalTokenType("GOTO", 17);
        public static PascalTokenType IF = new PascalTokenType("IF", 18);
        public static PascalTokenType IN = new PascalTokenType("IN", 19);
        public static PascalTokenType INTEGER = new PascalTokenType("INTEGER", 20);
        public static PascalTokenType LABEL = new PascalTokenType("LABEL", 21);
        public static PascalTokenType MOD = new PascalTokenType("MOD", 22);
        public static PascalTokenType NIL = new PascalTokenType("NIL", 23);
        public static PascalTokenType NOT = new PascalTokenType("NOT", 24);
        public static PascalTokenType OF = new PascalTokenType("OF", 25);
        public static PascalTokenType OR = new PascalTokenType("OR", 26);
        public static PascalTokenType PACKED = new PascalTokenType("PACKED", 27);
        public static PascalTokenType PROCEDURE = new PascalTokenType("PROCEDURE", 28);
        public static PascalTokenType PROGRAM = new PascalTokenType("PROGRAM", 29);
        public static PascalTokenType REAL = new PascalTokenType("REAL", 30);
        public static PascalTokenType RECORD = new PascalTokenType("RECORD", 31);
        public static PascalTokenType REPEAT = new PascalTokenType("REPEAT", 32);
        public static PascalTokenType SET = new PascalTokenType("SET", 33);
        public static PascalTokenType THEN = new PascalTokenType("THEN", 34);
        public static PascalTokenType TO = new PascalTokenType("TO", 35);
        public static PascalTokenType TYPE = new PascalTokenType("TYPE", 36);
        public static PascalTokenType UNTIL = new PascalTokenType("UNTIL", 37);
        public static PascalTokenType VAR = new PascalTokenType("VAR", 38);
        public static PascalTokenType WHILE = new PascalTokenType("WHILE", 39);
        public static PascalTokenType WITH = new PascalTokenType("WITH", 40);
        public static PascalTokenType PLUS = new PascalTokenType("PLUS", 41);
        public static PascalTokenType MINUS = new PascalTokenType("MINUS", 42);
        public static PascalTokenType STAR = new PascalTokenType("STAR", 43);
        public static PascalTokenType SLASH = new PascalTokenType("SLASH", 44);
        public static PascalTokenType ASSIGN = new PascalTokenType("ASSIGN", 45);
        public static PascalTokenType COMMA = new PascalTokenType("COMMA", 46);
        public static PascalTokenType SEMI = new PascalTokenType("SEMI", 47);
        public static PascalTokenType COLON = new PascalTokenType("COLON", 48);
        public static PascalTokenType EQUAL = new PascalTokenType("EQUAL", 49);
        public static PascalTokenType NOT_EQUAL = new PascalTokenType("NOT_EQUAL", 50);
        public static PascalTokenType LT = new PascalTokenType("LT", 51);
        public static PascalTokenType LE = new PascalTokenType("LE", 52);
        public static PascalTokenType GE = new PascalTokenType("GE", 53);
        public static PascalTokenType GT = new PascalTokenType("GT", 54);
        public static PascalTokenType LPAREN = new PascalTokenType("LPAREN", 55);
        public static PascalTokenType RPAREN = new PascalTokenType("RPAREN", 56);
        public static PascalTokenType LBRACK = new PascalTokenType("LBRACK", 57);
        public static PascalTokenType LBRACK2 = new PascalTokenType("LBRACK2", 58);
        public static PascalTokenType RBRACK = new PascalTokenType("RBRACK", 59);
        public static PascalTokenType RBRACK2 = new PascalTokenType("RBRACK2", 60);
        public static PascalTokenType POINTER = new PascalTokenType("POINTER", 61);
        public static PascalTokenType AT = new PascalTokenType("AT", 62);
        public static PascalTokenType DOT = new PascalTokenType("DOT", 63);
        public static PascalTokenType DOTDOT = new PascalTokenType("DOTDOT", 64);
        public static PascalTokenType LCURLY = new PascalTokenType("LCURLY", 65);
        public static PascalTokenType RCURLY = new PascalTokenType("RCURLY", 66);
        public static PascalTokenType UNIT = new PascalTokenType("UNIT", 67);
        public static PascalTokenType INTERFACE = new PascalTokenType("INTERFACE", 68);
        public static PascalTokenType USES = new PascalTokenType("USES", 69);
        public static PascalTokenType STRING = new PascalTokenType("STRING", 70);
        public static PascalTokenType IMPLEMENTATION = new PascalTokenType("IMPLEMENTATION", 71);
        public static PascalTokenType TRUE = new PascalTokenType("TRUE", 72);
        public static PascalTokenType FALSE = new PascalTokenType("FALSE", 73);
        public static PascalTokenType WS = new PascalTokenType("WS", 74);
        public static PascalTokenType COMMENT_1 = new PascalTokenType("COMMENT_1", 75);
        public static PascalTokenType COMMENT_2 = new PascalTokenType("COMMENT_2", 76);
        public static PascalTokenType IDENT = new PascalTokenType("IDENT", 77);
        public static PascalTokenType STRING_LITERAL = new PascalTokenType("STRING_LITERAL", 78);
        public static PascalTokenType NUM_INT = new PascalTokenType("NUM_INT", 79);
        public static PascalTokenType NUM_REAL = new PascalTokenType("NUM_REAL", 80);
        public static PascalTokenType PLUS_SIGN_SYM = new PascalTokenType("+", 41);
        public static PascalTokenType HYPHEN_MINUS_SYM = new PascalTokenType("-", 42);
        public static PascalTokenType ASTERISK_SYM = new PascalTokenType("*", 43);
        public static PascalTokenType SOLIDUS_SYM = new PascalTokenType("/", 44);
        public static PascalTokenType COLON_EQUALS_SIGN_SYM = new PascalTokenType(":=", 45);
        public static PascalTokenType COMMA_SYM = new PascalTokenType(",", 46);
        public static PascalTokenType SEMICOLON_SYM = new PascalTokenType(";", 47);
        public static PascalTokenType COLON_SYM = new PascalTokenType(":", 48);
        public static PascalTokenType EQUALS_SIGN_SYM = new PascalTokenType("=", 49);
        public static PascalTokenType LESS_THAN_SIGN_GREATER_THAN_SIGN_SYM = new PascalTokenType("<>", 50);
        public static PascalTokenType LESS_THAN_SIGN_SYM = new PascalTokenType("<", 51);
        public static PascalTokenType LESS_THAN_SIGN_EQUALS_SIGN_SYM = new PascalTokenType("<=", 52);
        public static PascalTokenType GREATER_THAN_SIGN_EQUALS_SIGN_SYM = new PascalTokenType(">=", 53);
        public static PascalTokenType GREATER_THAN_SIGN_SYM = new PascalTokenType(">", 54);
        public static PascalTokenType LEFT_PARENTHESIS_SYM = new PascalTokenType("(", 55);
        public static PascalTokenType RIGHT_PARENTHESIS_SYM = new PascalTokenType(")", 56);
        public static PascalTokenType LEFT_SQUARE_BRACKET_SYM = new PascalTokenType("[", 57);
        public static PascalTokenType LEFT_PARENTHESIS_FULL_STOP_SYM = new PascalTokenType("(.", 58);
        public static PascalTokenType RIGHT_SQUARE_BRACKET_SYM = new PascalTokenType("]", 59);
        public static PascalTokenType FULL_STOP_RIGHT_PARENTHESIS_SYM = new PascalTokenType(".)", 60);
        public static PascalTokenType CIRCUMFLEX_ACCENT_SYM = new PascalTokenType("^", 61);
        public static PascalTokenType COMMERCIAL_AT_SYM = new PascalTokenType("@", 62);
        public static PascalTokenType FULL_STOP_SYM = new PascalTokenType(".", 63);
        public static PascalTokenType FULL_STOP_FULL_STOP_SYM = new PascalTokenType("..", 64);
        public static PascalTokenType LEFT_CURLY_BRACKET_SYM = new PascalTokenType("{", 65);
        public static PascalTokenType RIGHT_CURLY_BRACKET_SYM = new PascalTokenType("}", 66);

        public static PascalTokenType UNKNOWN = new PascalTokenType("UNKNOWN", 81);

        public static readonly HashSet<PascalTokenType> Keywords = new HashSet<PascalTokenType>
        {
            AND, ARRAY, BEGIN, BOOLEAN, CASE, CHAR, CHR, CONST, DIV, DO, DOWNTO, ELSE, END, FILE, FOR, FUNCTION, GOTO,
            IF, IN, INTEGER, LABEL, MOD, NIL, NOT, OF, OR, PACKED, PROCEDURE, PROGRAM, REAL, RECORD, REPEAT, SET, THEN,
            TO, TYPE, UNTIL, VAR, WHILE, WITH, UNIT, INTERFACE, USES, STRING, IMPLEMENTATION,
        };

        public static readonly HashSet<PascalTokenType> Constants = new HashSet<PascalTokenType>
        {
            NUM_INT, NUM_REAL, TRUE, FALSE
        };

        public static void Register(PascalTokenType type)
        {
            ConvertTo[type.Index] = type;
        }
    }
}