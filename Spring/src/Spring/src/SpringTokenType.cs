using System.Collections.Generic;
using System.Text;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.Text;
using JetBrains.Util;
using JetBrains.Util.Collections;

namespace JetBrains.ReSharper.Plugins.Spring
{
    class SpringTokenType : TokenNodeType
    {
        private static HashMap<int, SpringTokenType> convertTo = new HashMap<int, SpringTokenType>();
        private static HashMap<SpringTokenType, int> convertFrom = new HashMap<SpringTokenType, int>();

        public static SpringTokenType Convert(int index)
        {
            init();
            if (!convertTo.ContainsKey(index))
            {
                Logger.Log($"Index {index} is unknown");
            }
            return convertTo[index];
        }

        public static int Convert(SpringTokenType type)
        {
            init();
            return convertFrom[type];
        }

        public static SpringTokenType AND = new SpringTokenType("AND", 1);
        public static SpringTokenType ARRAY = new SpringTokenType("ARRAY", 2);
        public static SpringTokenType BEGIN = new SpringTokenType("BEGIN", 3);
        public static SpringTokenType BOOLEAN = new SpringTokenType("BOOLEAN", 4);
        public static SpringTokenType CASE = new SpringTokenType("CASE", 5);
        public static SpringTokenType CHAR = new SpringTokenType("CHAR", 6);
        public static SpringTokenType CHR = new SpringTokenType("CHR", 7);
        public static SpringTokenType CONST = new SpringTokenType("CONST", 8);
        public static SpringTokenType DIV = new SpringTokenType("DIV", 9);
        public static SpringTokenType DO = new SpringTokenType("DO", 10);
        public static SpringTokenType DOWNTO = new SpringTokenType("DOWNTO", 11);
        public static SpringTokenType ELSE = new SpringTokenType("ELSE", 12);
        public static SpringTokenType END = new SpringTokenType("END", 13);
        public static SpringTokenType FILE = new SpringTokenType("FILE", 14);
        public static SpringTokenType FOR = new SpringTokenType("FOR", 15);
        public static SpringTokenType FUNCTION = new SpringTokenType("FUNCTION", 16);
        public static SpringTokenType GOTO = new SpringTokenType("GOTO", 17);
        public static SpringTokenType IF = new SpringTokenType("IF", 18);
        public static SpringTokenType IN = new SpringTokenType("IN", 19);
        public static SpringTokenType INTEGER = new SpringTokenType("INTEGER", 20);
        public static SpringTokenType LABEL = new SpringTokenType("LABEL", 21);
        public static SpringTokenType MOD = new SpringTokenType("MOD", 22);
        public static SpringTokenType NIL = new SpringTokenType("NIL", 23);
        public static SpringTokenType NOT = new SpringTokenType("NOT", 24);
        public static SpringTokenType OF = new SpringTokenType("OF", 25);
        public static SpringTokenType OR = new SpringTokenType("OR", 26);
        public static SpringTokenType PACKED = new SpringTokenType("PACKED", 27);
        public static SpringTokenType PROCEDURE = new SpringTokenType("PROCEDURE", 28);
        public static SpringTokenType PROGRAM = new SpringTokenType("PROGRAM", 29);
        public static SpringTokenType REAL = new SpringTokenType("REAL", 30);
        public static SpringTokenType RECORD = new SpringTokenType("RECORD", 31);
        public static SpringTokenType REPEAT = new SpringTokenType("REPEAT", 32);
        public static SpringTokenType SET = new SpringTokenType("SET", 33);
        public static SpringTokenType THEN = new SpringTokenType("THEN", 34);
        public static SpringTokenType TO = new SpringTokenType("TO", 35);
        public static SpringTokenType TYPE = new SpringTokenType("TYPE", 36);
        public static SpringTokenType UNTIL = new SpringTokenType("UNTIL", 37);
        public static SpringTokenType VAR = new SpringTokenType("VAR", 38);
        public static SpringTokenType WHILE = new SpringTokenType("WHILE", 39);
        public static SpringTokenType WITH = new SpringTokenType("WITH", 40);
        public static SpringTokenType PLUS = new SpringTokenType("PLUS", 41);
        public static SpringTokenType MINUS = new SpringTokenType("MINUS", 42);
        public static SpringTokenType STAR = new SpringTokenType("STAR", 43);
        public static SpringTokenType SLASH = new SpringTokenType("SLASH", 44);
        public static SpringTokenType ASSIGN = new SpringTokenType("ASSIGN", 45);
        public static SpringTokenType COMMA = new SpringTokenType("COMMA", 46);
        public static SpringTokenType SEMI = new SpringTokenType("SEMI", 47);
        public static SpringTokenType COLON = new SpringTokenType("COLON", 48);
        public static SpringTokenType EQUAL = new SpringTokenType("EQUAL", 49);
        public static SpringTokenType NOT_EQUAL = new SpringTokenType("NOT_EQUAL", 50);
        public static SpringTokenType LT = new SpringTokenType("LT", 51);
        public static SpringTokenType LE = new SpringTokenType("LE", 52);
        public static SpringTokenType GE = new SpringTokenType("GE", 53);
        public static SpringTokenType GT = new SpringTokenType("GT", 54);
        public static SpringTokenType LPAREN = new SpringTokenType("LPAREN", 55);
        public static SpringTokenType RPAREN = new SpringTokenType("RPAREN", 56);
        public static SpringTokenType LBRACK = new SpringTokenType("LBRACK", 57);
        public static SpringTokenType LBRACK2 = new SpringTokenType("LBRACK2", 58);
        public static SpringTokenType RBRACK = new SpringTokenType("RBRACK", 59);
        public static SpringTokenType RBRACK2 = new SpringTokenType("RBRACK2", 60);
        public static SpringTokenType POINTER = new SpringTokenType("POINTER", 61);
        public static SpringTokenType AT = new SpringTokenType("AT", 62);
        public static SpringTokenType DOT = new SpringTokenType("DOT", 63);
        public static SpringTokenType DOTDOT = new SpringTokenType("DOTDOT", 64);
        public static SpringTokenType LCURLY = new SpringTokenType("LCURLY", 65);
        public static SpringTokenType RCURLY = new SpringTokenType("RCURLY", 66);
        public static SpringTokenType UNIT = new SpringTokenType("UNIT", 67);
        public static SpringTokenType INTERFACE = new SpringTokenType("INTERFACE", 68);
        public static SpringTokenType USES = new SpringTokenType("USES", 69);
        public static SpringTokenType STRING = new SpringTokenType("STRING", 70);
        public static SpringTokenType IMPLEMENTATION = new SpringTokenType("IMPLEMENTATION", 71);
        public static SpringTokenType TRUE = new SpringTokenType("TRUE", 72);
        public static SpringTokenType FALSE = new SpringTokenType("FALSE", 73);
        public static SpringTokenType WS = new SpringTokenType("WS", 74);
        public static SpringTokenType COMMENT_1 = new SpringTokenType("COMMENT_1", 75);
        public static SpringTokenType COMMENT_2 = new SpringTokenType("COMMENT_2", 76);
        public static SpringTokenType IDENT = new SpringTokenType("IDENT", 77);
        public static SpringTokenType STRING_LITERAL = new SpringTokenType("STRING_LITERAL", 78);
        public static SpringTokenType NUM_INT = new SpringTokenType("NUM_INT", 79);
        public static SpringTokenType NUM_REAL = new SpringTokenType("NUM_REAL", 80);
        public static SpringTokenType PLUS_SIGN_SYM = new SpringTokenType("+", 41);
        public static SpringTokenType HYPHEN_MINUS_SYM = new SpringTokenType("-", 42);
        public static SpringTokenType ASTERISK_SYM = new SpringTokenType("*", 43);
        public static SpringTokenType SOLIDUS_SYM = new SpringTokenType("/", 44);
        public static SpringTokenType COLON_EQUALS_SIGN_SYM = new SpringTokenType(":=", 45);
        public static SpringTokenType COMMA_SYM = new SpringTokenType(",", 46);
        public static SpringTokenType SEMICOLON_SYM = new SpringTokenType(";", 47);
        public static SpringTokenType COLON_SYM = new SpringTokenType(":", 48);
        public static SpringTokenType EQUALS_SIGN_SYM = new SpringTokenType("=", 49);
        public static SpringTokenType LESS_THAN_SIGN_GREATER_THAN_SIGN_SYM = new SpringTokenType("<>", 50);
        public static SpringTokenType LESS_THAN_SIGN_SYM = new SpringTokenType("<", 51);
        public static SpringTokenType LESS_THAN_SIGN_EQUALS_SIGN_SYM = new SpringTokenType("<=", 52);
        public static SpringTokenType GREATER_THAN_SIGN_EQUALS_SIGN_SYM = new SpringTokenType(">=", 53);
        public static SpringTokenType GREATER_THAN_SIGN_SYM = new SpringTokenType(">", 54);
        public static SpringTokenType LEFT_PARENTHESIS_SYM = new SpringTokenType("(", 55);
        public static SpringTokenType RIGHT_PARENTHESIS_SYM = new SpringTokenType(")", 56);
        public static SpringTokenType LEFT_SQUARE_BRACKET_SYM = new SpringTokenType("[", 57);
        public static SpringTokenType LEFT_PARENTHESIS_FULL_STOP_SYM = new SpringTokenType("(.", 58);
        public static SpringTokenType RIGHT_SQUARE_BRACKET_SYM = new SpringTokenType("]", 59);
        public static SpringTokenType FULL_STOP_RIGHT_PARENTHESIS_SYM = new SpringTokenType(".)", 60);
        public static SpringTokenType CIRCUMFLEX_ACCENT_SYM = new SpringTokenType("^", 61);
        public static SpringTokenType COMMERCIAL_AT_SYM = new SpringTokenType("@", 62);
        public static SpringTokenType FULL_STOP_SYM = new SpringTokenType(".", 63);
        public static SpringTokenType FULL_STOP_FULL_STOP_SYM = new SpringTokenType("..", 64);
        public static SpringTokenType LEFT_CURLY_BRACKET_SYM = new SpringTokenType("{", 65);
        public static SpringTokenType RIGHT_CURLY_BRACKET_SYM = new SpringTokenType("}", 66);

        private static bool isInitialized = false;

        public static void init()
        {
            if (isInitialized) return;

            NUM_REAL.Register();
            VAR.Register();
            RBRACK2.Register();
            MINUS.Register();
            INTERFACE.Register();
            DOWNTO.Register();
            ELSE.Register();
            RIGHT_CURLY_BRACKET_SYM.Register();
            IF.Register();
            TYPE.Register();
            LBRACK2.Register();
            RIGHT_SQUARE_BRACKET_SYM.Register();
            IN.Register();
            LPAREN.Register();
            DOT.Register();
            FUNCTION.Register();
            CASE.Register();
            PLUS_SIGN_SYM.Register();
            AT.Register();
            LBRACK.Register();
            THEN.Register();
            LESS_THAN_SIGN_SYM.Register();
            PROGRAM.Register();
            GOTO.Register();
            SET.Register();
            LESS_THAN_SIGN_EQUALS_SIGN_SYM.Register();
            REPEAT.Register();
            SEMI.Register();
            CHAR.Register();
            BEGIN.Register();
            ASSIGN.Register();
            FULL_STOP_SYM.Register();
            PACKED.Register();
            CIRCUMFLEX_ACCENT_SYM.Register();
            FILE.Register();
            RCURLY.Register();
            COMMA.Register();
            COLON_EQUALS_SIGN_SYM.Register();
            PROCEDURE.Register();
            HYPHEN_MINUS_SYM.Register();
            RIGHT_PARENTHESIS_SYM.Register();
            LCURLY.Register();
            DIV.Register();
            STAR.Register();
            NOT_EQUAL.Register();
            LE.Register();
            STRING.Register();
            TO.Register();
            FULL_STOP_RIGHT_PARENTHESIS_SYM.Register();
            ARRAY.Register();
            RECORD.Register();
            LT.Register();
            DO.Register();
            CHR.Register();
            CONST.Register();
            LABEL.Register();
            SOLIDUS_SYM.Register();
            LEFT_PARENTHESIS_FULL_STOP_SYM.Register();
            INTEGER.Register();
            COMMERCIAL_AT_SYM.Register();
            COLON_SYM.Register();
            UNIT.Register();
            FULL_STOP_FULL_STOP_SYM.Register();
            FOR.Register();
            TRUE.Register();
            RPAREN.Register();
            LEFT_SQUARE_BRACKET_SYM.Register();
            BOOLEAN.Register();
            GREATER_THAN_SIGN_SYM.Register();
            NOT.Register();
            RBRACK.Register();
            AND.Register();
            REAL.Register();
            END.Register();
            LESS_THAN_SIGN_GREATER_THAN_SIGN_SYM.Register();
            PLUS.Register();
            LEFT_PARENTHESIS_SYM.Register();
            COMMENT_2.Register();
            COMMENT_1.Register();
            COMMA_SYM.Register();
            OF.Register();
            ASTERISK_SYM.Register();
            LEFT_CURLY_BRACKET_SYM.Register();
            WS.Register();
            GE.Register();
            MOD.Register();
            OR.Register();
            SEMICOLON_SYM.Register();
            EQUAL.Register();
            SLASH.Register();
            IMPLEMENTATION.Register();
            COLON.Register();
            DOTDOT.Register();
            USES.Register();
            EQUALS_SIGN_SYM.Register();
            UNTIL.Register();
            GT.Register();
            NUM_INT.Register();
            WITH.Register();
            NIL.Register();
            IDENT.Register();
            POINTER.Register();
            WHILE.Register();
            FALSE.Register();
            STRING_LITERAL.Register();
            GREATER_THAN_SIGN_EQUALS_SIGN_SYM.Register();

            isInitialized = true;
        }

        public SpringTokenType(string s, int index) : base(s, index)
        {
        }

        private void Register()
        {
            convertTo[Index] = this;
            convertFrom[this] = Index;
        }

        private class SpringGenericToken : LeafElementBase, ITokenNode
        {
            private readonly string _myText;
            private readonly SpringTokenType _myType;

            public SpringGenericToken(string text, SpringTokenType tokenType)
            {
                _myText = text;
                _myType = tokenType;
            }
            
            public override int GetTextLength()
            {
                return _myText.Length;
            }

            public override string GetText()
            {
                return _myText;
            }

            public override StringBuilder GetText(StringBuilder to)
            {
                to.Append(GetText());
                return to;
            }

            public override IBuffer GetTextAsBuffer()
            {
                return new StringBuffer(GetText());
            }
            
            public override string ToString()
            {
                return base.ToString() + "(type:" + _myType + ", text:" + _myText + ")";
            }

            public override NodeType NodeType => _myType;
            public override PsiLanguageType Language => SpringLanguage.Instance;
            public TokenNodeType GetTokenType()
            {
                return _myType;
            }
        }

        public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
        {
            return new SpringGenericToken(buffer.GetText(new TextRange(startOffset.Offset, endOffset.Offset)), this);
        }

        public override bool IsWhitespace => this == WS;
        public override bool IsComment => this == COMMENT_1 || this == COMMENT_2;
        public override bool IsStringLiteral => this == STRING_LITERAL || this == STRING;
        public override bool IsConstantLiteral { get; }
        public override bool IsIdentifier => this == IDENT;
        public override bool IsKeyword => this == PROGRAM || this == END || this == BEGIN || this == DOT || this == TRUE || this == FALSE;
        public override string TokenRepresentation { get; }
    }
}