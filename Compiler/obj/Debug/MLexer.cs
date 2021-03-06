//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\mariusg\Documents\Visual Studio 2013\Projects\Compiler\Compiler\Parser\Antlr\MLexer.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Compiler.Parser.Antlr {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class MLexer : Lexer {
	public const int
		Break=1, Void=2, Int=3, If=4, Else=5, For=6, Return=7, New=8, Double=9, 
		String=10, While=11, Bool=12, True=13, False=14, LeftParen=15, RightParen=16, 
		LeftBrace=17, RightBrace=18, LeftBracket=19, RightBracket=20, Less=21, 
		LessEqual=22, Greater=23, GreaterEqual=24, Equal=25, NotEqual=26, Plus=27, 
		Minus=28, Star=29, StarStar=30, Div=31, Mod=32, AndAnd=33, OrOr=34, Not=35, 
		Semi=36, Comma=37, Assign=38, Identifier=39, IntegerConstant=40, DoubleConstant=41, 
		StringConstant=42, Whitespace=43, Comment=44, LineComment=45;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] tokenNames = {
		"'\\u0000'", "'\\u0001'", "'\\u0002'", "'\\u0003'", "'\\u0004'", "'\\u0005'", 
		"'\\u0006'", "'\\u0007'", "'\b'", "'\t'", "'\n'", "'\\u000B'", "'\f'", 
		"'\r'", "'\\u000E'", "'\\u000F'", "'\\u0010'", "'\\u0011'", "'\\u0012'", 
		"'\\u0013'", "'\\u0014'", "'\\u0015'", "'\\u0016'", "'\\u0017'", "'\\u0018'", 
		"'\\u0019'", "'\\u001A'", "'\\u001B'", "'\\u001C'", "'\\u001D'", "'\\u001E'", 
		"'\\u001F'", "' '", "'!'", "'\"'", "'#'", "'$'", "'%'", "'&'", "'''", 
		"'('", "')'", "'*'", "'+'", "','", "'-'"
	};
	public static readonly string[] ruleNames = {
		"Break", "Void", "Int", "If", "Else", "For", "Return", "New", "Double", 
		"String", "While", "Bool", "True", "False", "LeftParen", "RightParen", 
		"LeftBrace", "RightBrace", "LeftBracket", "RightBracket", "Less", "LessEqual", 
		"Greater", "GreaterEqual", "Equal", "NotEqual", "Plus", "Minus", "Star", 
		"StarStar", "Div", "Mod", "AndAnd", "OrOr", "Not", "Semi", "Comma", "Assign", 
		"Identifier", "IntegerConstant", "DoubleConstant", "StringConstant", "Whitespace", 
		"Comment", "LineComment", "Digit", "Letter", "LetterAndDigit", "StringCharacters", 
		"StringCharacter"
	};


	public MLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	public override string GrammarFileName { get { return "MLexer.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2/\x132\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31\x4\x32"+
		"\t\x32\x4\x33\t\x33\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6"+
		"\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3"+
		"\v\x3\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3"+
		"\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3"+
		"\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3"+
		"\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3"+
		"\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3"+
		"\x1C\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3!\x3!"+
		"\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3$\x3$\x3%\x3%\x3&\x3&\x3\'\x3\'\x3(\x3("+
		"\a(\xEB\n(\f(\xE(\xEE\v(\x3)\x6)\xF1\n)\r)\xE)\xF2\x3*\x6*\xF6\n*\r*\xE"+
		"*\xF7\x3*\x3*\x6*\xFC\n*\r*\xE*\xFD\x3+\x3+\x5+\x102\n+\x3+\x3+\x3,\x6"+
		",\x107\n,\r,\xE,\x108\x3,\x3,\x3-\x3-\x3-\x3-\a-\x111\n-\f-\xE-\x114\v"+
		"-\x3-\x3-\x3-\x3-\x3-\x3.\x3.\x3.\x3.\a.\x11F\n.\f.\xE.\x122\v.\x3.\x3"+
		".\x3/\x3/\x3\x30\x3\x30\x3\x31\x3\x31\x3\x32\x6\x32\x12D\n\x32\r\x32\xE"+
		"\x32\x12E\x3\x33\x3\x33\x3\x112\x2\x2\x34\x3\x2\x3\x5\x2\x4\a\x2\x5\t"+
		"\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2"+
		"\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)"+
		"\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2"+
		"\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&K"+
		"\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2,W\x2-Y\x2.[\x2/]\x2\x2_\x2\x2\x61\x2\x2"+
		"\x63\x2\x2\x65\x2\x2\x3\x2\b\x5\x2\v\f\xF\xF\"\"\x4\x2\f\f\xF\xF\x3\x2"+
		"\x32;\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x4\x2$$^"+
		"^\x135\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2"+
		"\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2"+
		"\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19"+
		"\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2"+
		"\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)"+
		"\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3"+
		"\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2"+
		"\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41"+
		"\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2"+
		"I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2"+
		"\x2\x2\x2S\x3\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2"+
		"\x2[\x3\x2\x2\x2\x3g\x3\x2\x2\x2\x5m\x3\x2\x2\x2\ar\x3\x2\x2\x2\tv\x3"+
		"\x2\x2\x2\vy\x3\x2\x2\x2\r~\x3\x2\x2\x2\xF\x82\x3\x2\x2\x2\x11\x89\x3"+
		"\x2\x2\x2\x13\x8D\x3\x2\x2\x2\x15\x94\x3\x2\x2\x2\x17\x9B\x3\x2\x2\x2"+
		"\x19\xA1\x3\x2\x2\x2\x1B\xA6\x3\x2\x2\x2\x1D\xAB\x3\x2\x2\x2\x1F\xB1\x3"+
		"\x2\x2\x2!\xB3\x3\x2\x2\x2#\xB5\x3\x2\x2\x2%\xB7\x3\x2\x2\x2\'\xB9\x3"+
		"\x2\x2\x2)\xBB\x3\x2\x2\x2+\xBD\x3\x2\x2\x2-\xBF\x3\x2\x2\x2/\xC2\x3\x2"+
		"\x2\x2\x31\xC4\x3\x2\x2\x2\x33\xC7\x3\x2\x2\x2\x35\xCA\x3\x2\x2\x2\x37"+
		"\xCD\x3\x2\x2\x2\x39\xCF\x3\x2\x2\x2;\xD1\x3\x2\x2\x2=\xD3\x3\x2\x2\x2"+
		"?\xD6\x3\x2\x2\x2\x41\xD8\x3\x2\x2\x2\x43\xDA\x3\x2\x2\x2\x45\xDD\x3\x2"+
		"\x2\x2G\xE0\x3\x2\x2\x2I\xE2\x3\x2\x2\x2K\xE4\x3\x2\x2\x2M\xE6\x3\x2\x2"+
		"\x2O\xE8\x3\x2\x2\x2Q\xF0\x3\x2\x2\x2S\xF5\x3\x2\x2\x2U\xFF\x3\x2\x2\x2"+
		"W\x106\x3\x2\x2\x2Y\x10C\x3\x2\x2\x2[\x11A\x3\x2\x2\x2]\x125\x3\x2\x2"+
		"\x2_\x127\x3\x2\x2\x2\x61\x129\x3\x2\x2\x2\x63\x12C\x3\x2\x2\x2\x65\x130"+
		"\x3\x2\x2\x2gh\a\x64\x2\x2hi\at\x2\x2ij\ag\x2\x2jk\a\x63\x2\x2kl\am\x2"+
		"\x2l\x4\x3\x2\x2\x2mn\ax\x2\x2no\aq\x2\x2op\ak\x2\x2pq\a\x66\x2\x2q\x6"+
		"\x3\x2\x2\x2rs\ak\x2\x2st\ap\x2\x2tu\av\x2\x2u\b\x3\x2\x2\x2vw\ak\x2\x2"+
		"wx\ah\x2\x2x\n\x3\x2\x2\x2yz\ag\x2\x2z{\an\x2\x2{|\au\x2\x2|}\ag\x2\x2"+
		"}\f\x3\x2\x2\x2~\x7F\ah\x2\x2\x7F\x80\aq\x2\x2\x80\x81\at\x2\x2\x81\xE"+
		"\x3\x2\x2\x2\x82\x83\at\x2\x2\x83\x84\ag\x2\x2\x84\x85\av\x2\x2\x85\x86"+
		"\aw\x2\x2\x86\x87\at\x2\x2\x87\x88\ap\x2\x2\x88\x10\x3\x2\x2\x2\x89\x8A"+
		"\ap\x2\x2\x8A\x8B\ag\x2\x2\x8B\x8C\ay\x2\x2\x8C\x12\x3\x2\x2\x2\x8D\x8E"+
		"\a\x66\x2\x2\x8E\x8F\aq\x2\x2\x8F\x90\aw\x2\x2\x90\x91\a\x64\x2\x2\x91"+
		"\x92\an\x2\x2\x92\x93\ag\x2\x2\x93\x14\x3\x2\x2\x2\x94\x95\au\x2\x2\x95"+
		"\x96\av\x2\x2\x96\x97\at\x2\x2\x97\x98\ak\x2\x2\x98\x99\ap\x2\x2\x99\x9A"+
		"\ai\x2\x2\x9A\x16\x3\x2\x2\x2\x9B\x9C\ay\x2\x2\x9C\x9D\aj\x2\x2\x9D\x9E"+
		"\ak\x2\x2\x9E\x9F\an\x2\x2\x9F\xA0\ag\x2\x2\xA0\x18\x3\x2\x2\x2\xA1\xA2"+
		"\a\x64\x2\x2\xA2\xA3\aq\x2\x2\xA3\xA4\aq\x2\x2\xA4\xA5\an\x2\x2\xA5\x1A"+
		"\x3\x2\x2\x2\xA6\xA7\av\x2\x2\xA7\xA8\at\x2\x2\xA8\xA9\aw\x2\x2\xA9\xAA"+
		"\ag\x2\x2\xAA\x1C\x3\x2\x2\x2\xAB\xAC\ah\x2\x2\xAC\xAD\a\x63\x2\x2\xAD"+
		"\xAE\an\x2\x2\xAE\xAF\au\x2\x2\xAF\xB0\ag\x2\x2\xB0\x1E\x3\x2\x2\x2\xB1"+
		"\xB2\a*\x2\x2\xB2 \x3\x2\x2\x2\xB3\xB4\a+\x2\x2\xB4\"\x3\x2\x2\x2\xB5"+
		"\xB6\a}\x2\x2\xB6$\x3\x2\x2\x2\xB7\xB8\a\x7F\x2\x2\xB8&\x3\x2\x2\x2\xB9"+
		"\xBA\a]\x2\x2\xBA(\x3\x2\x2\x2\xBB\xBC\a_\x2\x2\xBC*\x3\x2\x2\x2\xBD\xBE"+
		"\a>\x2\x2\xBE,\x3\x2\x2\x2\xBF\xC0\a>\x2\x2\xC0\xC1\a?\x2\x2\xC1.\x3\x2"+
		"\x2\x2\xC2\xC3\a@\x2\x2\xC3\x30\x3\x2\x2\x2\xC4\xC5\a@\x2\x2\xC5\xC6\a"+
		"?\x2\x2\xC6\x32\x3\x2\x2\x2\xC7\xC8\a?\x2\x2\xC8\xC9\a?\x2\x2\xC9\x34"+
		"\x3\x2\x2\x2\xCA\xCB\a#\x2\x2\xCB\xCC\a?\x2\x2\xCC\x36\x3\x2\x2\x2\xCD"+
		"\xCE\a-\x2\x2\xCE\x38\x3\x2\x2\x2\xCF\xD0\a/\x2\x2\xD0:\x3\x2\x2\x2\xD1"+
		"\xD2\a,\x2\x2\xD2<\x3\x2\x2\x2\xD3\xD4\a,\x2\x2\xD4\xD5\a,\x2\x2\xD5>"+
		"\x3\x2\x2\x2\xD6\xD7\a\x31\x2\x2\xD7@\x3\x2\x2\x2\xD8\xD9\a\'\x2\x2\xD9"+
		"\x42\x3\x2\x2\x2\xDA\xDB\a(\x2\x2\xDB\xDC\a(\x2\x2\xDC\x44\x3\x2\x2\x2"+
		"\xDD\xDE\a~\x2\x2\xDE\xDF\a~\x2\x2\xDF\x46\x3\x2\x2\x2\xE0\xE1\a#\x2\x2"+
		"\xE1H\x3\x2\x2\x2\xE2\xE3\a=\x2\x2\xE3J\x3\x2\x2\x2\xE4\xE5\a.\x2\x2\xE5"+
		"L\x3\x2\x2\x2\xE6\xE7\a?\x2\x2\xE7N\x3\x2\x2\x2\xE8\xEC\x5_\x30\x2\xE9"+
		"\xEB\x5\x61\x31\x2\xEA\xE9\x3\x2\x2\x2\xEB\xEE\x3\x2\x2\x2\xEC\xEA\x3"+
		"\x2\x2\x2\xEC\xED\x3\x2\x2\x2\xEDP\x3\x2\x2\x2\xEE\xEC\x3\x2\x2\x2\xEF"+
		"\xF1\x5]/\x2\xF0\xEF\x3\x2\x2\x2\xF1\xF2\x3\x2\x2\x2\xF2\xF0\x3\x2\x2"+
		"\x2\xF2\xF3\x3\x2\x2\x2\xF3R\x3\x2\x2\x2\xF4\xF6\x5]/\x2\xF5\xF4\x3\x2"+
		"\x2\x2\xF6\xF7\x3\x2\x2\x2\xF7\xF5\x3\x2\x2\x2\xF7\xF8\x3\x2\x2\x2\xF8"+
		"\xF9\x3\x2\x2\x2\xF9\xFB\a\x30\x2\x2\xFA\xFC\x5]/\x2\xFB\xFA\x3\x2\x2"+
		"\x2\xFC\xFD\x3\x2\x2\x2\xFD\xFB\x3\x2\x2\x2\xFD\xFE\x3\x2\x2\x2\xFET\x3"+
		"\x2\x2\x2\xFF\x101\a$\x2\x2\x100\x102\x5\x63\x32\x2\x101\x100\x3\x2\x2"+
		"\x2\x101\x102\x3\x2\x2\x2\x102\x103\x3\x2\x2\x2\x103\x104\a$\x2\x2\x104"+
		"V\x3\x2\x2\x2\x105\x107\t\x2\x2\x2\x106\x105\x3\x2\x2\x2\x107\x108\x3"+
		"\x2\x2\x2\x108\x106\x3\x2\x2\x2\x108\x109\x3\x2\x2\x2\x109\x10A\x3\x2"+
		"\x2\x2\x10A\x10B\b,\x2\x2\x10BX\x3\x2\x2\x2\x10C\x10D\a\x31\x2\x2\x10D"+
		"\x10E\a,\x2\x2\x10E\x112\x3\x2\x2\x2\x10F\x111\v\x2\x2\x2\x110\x10F\x3"+
		"\x2\x2\x2\x111\x114\x3\x2\x2\x2\x112\x113\x3\x2\x2\x2\x112\x110\x3\x2"+
		"\x2\x2\x113\x115\x3\x2\x2\x2\x114\x112\x3\x2\x2\x2\x115\x116\a,\x2\x2"+
		"\x116\x117\a\x31\x2\x2\x117\x118\x3\x2\x2\x2\x118\x119\b-\x2\x2\x119Z"+
		"\x3\x2\x2\x2\x11A\x11B\a\x31\x2\x2\x11B\x11C\a\x31\x2\x2\x11C\x120\x3"+
		"\x2\x2\x2\x11D\x11F\n\x3\x2\x2\x11E\x11D\x3\x2\x2\x2\x11F\x122\x3\x2\x2"+
		"\x2\x120\x11E\x3\x2\x2\x2\x120\x121\x3\x2\x2\x2\x121\x123\x3\x2\x2\x2"+
		"\x122\x120\x3\x2\x2\x2\x123\x124\b.\x2\x2\x124\\\x3\x2\x2\x2\x125\x126"+
		"\t\x4\x2\x2\x126^\x3\x2\x2\x2\x127\x128\t\x5\x2\x2\x128`\x3\x2\x2\x2\x129"+
		"\x12A\t\x6\x2\x2\x12A\x62\x3\x2\x2\x2\x12B\x12D\x5\x65\x33\x2\x12C\x12B"+
		"\x3\x2\x2\x2\x12D\x12E\x3\x2\x2\x2\x12E\x12C\x3\x2\x2\x2\x12E\x12F\x3"+
		"\x2\x2\x2\x12F\x64\x3\x2\x2\x2\x130\x131\n\a\x2\x2\x131\x66\x3\x2\x2\x2"+
		"\f\x2\xEC\xF2\xF7\xFD\x101\x108\x112\x120\x12E\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Compiler.Parser.Antlr
