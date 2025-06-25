// Generated from HomeGrammar.g4 by ANTLR 4.13.2
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue", "this-escape"})
public class HomeGrammarLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.13.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, TURN=2, STATE=3, UPDATE=4, TASK=5, I_AM=6, IT_IS=7, DEVICE=8, 
		TASK_DEVICE=9, FEELING=10, TIME_OF_DAY=11, WS=12;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "TURN", "STATE", "UPDATE", "TASK", "I_AM", "IT_IS", "DEVICE", 
			"TASK_DEVICE", "FEELING", "TIME_OF_DAY", "WS"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "';'", "'turn'", null, "'update'", "'start'", "'i am'", "'it is'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, "TURN", "STATE", "UPDATE", "TASK", "I_AM", "IT_IS", "DEVICE", 
			"TASK_DEVICE", "FEELING", "TIME_OF_DAY", "WS"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public HomeGrammarLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "HomeGrammar.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\u0004\u0000\f\u00b2\u0006\uffff\uffff\u0002\u0000\u0007\u0000\u0002\u0001"+
		"\u0007\u0001\u0002\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004"+
		"\u0007\u0004\u0002\u0005\u0007\u0005\u0002\u0006\u0007\u0006\u0002\u0007"+
		"\u0007\u0007\u0002\b\u0007\b\u0002\t\u0007\t\u0002\n\u0007\n\u0002\u000b"+
		"\u0007\u000b\u0001\u0000\u0001\u0000\u0001\u0001\u0001\u0001\u0001\u0001"+
		"\u0001\u0001\u0001\u0001\u0001\u0002\u0001\u0002\u0001\u0002\u0001\u0002"+
		"\u0001\u0002\u0003\u0002&\b\u0002\u0001\u0003\u0001\u0003\u0001\u0003"+
		"\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0004\u0001\u0004"+
		"\u0001\u0004\u0001\u0004\u0001\u0004\u0001\u0004\u0001\u0005\u0001\u0005"+
		"\u0001\u0005\u0001\u0005\u0001\u0005\u0001\u0006\u0001\u0006\u0001\u0006"+
		"\u0001\u0006\u0001\u0006\u0001\u0006\u0001\u0007\u0001\u0007\u0001\u0007"+
		"\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007"+
		"\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007"+
		"\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007"+
		"\u0003\u0007U\b\u0007\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b"+
		"\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001"+
		"\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001"+
		"\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001\b\u0001"+
		"\b\u0001\b\u0001\b\u0001\b\u0001\b\u0003\b|\b\b\u0001\t\u0001\t\u0001"+
		"\t\u0001\t\u0001\t\u0001\t\u0001\t\u0001\t\u0001\t\u0001\t\u0001\t\u0001"+
		"\t\u0001\t\u0001\t\u0003\t\u008c\b\t\u0001\n\u0001\n\u0001\n\u0001\n\u0001"+
		"\n\u0001\n\u0001\n\u0001\n\u0001\n\u0001\n\u0001\n\u0001\n\u0001\n\u0001"+
		"\n\u0001\n\u0001\n\u0001\n\u0001\n\u0001\n\u0001\n\u0001\n\u0001\n\u0001"+
		"\n\u0001\n\u0001\n\u0001\n\u0001\n\u0001\n\u0003\n\u00aa\b\n\u0001\u000b"+
		"\u0004\u000b\u00ad\b\u000b\u000b\u000b\f\u000b\u00ae\u0001\u000b\u0001"+
		"\u000b\u0000\u0000\f\u0001\u0001\u0003\u0002\u0005\u0003\u0007\u0004\t"+
		"\u0005\u000b\u0006\r\u0007\u000f\b\u0011\t\u0013\n\u0015\u000b\u0017\f"+
		"\u0001\u0000\u0001\u0003\u0000\t\n\r\r  \u00bd\u0000\u0001\u0001\u0000"+
		"\u0000\u0000\u0000\u0003\u0001\u0000\u0000\u0000\u0000\u0005\u0001\u0000"+
		"\u0000\u0000\u0000\u0007\u0001\u0000\u0000\u0000\u0000\t\u0001\u0000\u0000"+
		"\u0000\u0000\u000b\u0001\u0000\u0000\u0000\u0000\r\u0001\u0000\u0000\u0000"+
		"\u0000\u000f\u0001\u0000\u0000\u0000\u0000\u0011\u0001\u0000\u0000\u0000"+
		"\u0000\u0013\u0001\u0000\u0000\u0000\u0000\u0015\u0001\u0000\u0000\u0000"+
		"\u0000\u0017\u0001\u0000\u0000\u0000\u0001\u0019\u0001\u0000\u0000\u0000"+
		"\u0003\u001b\u0001\u0000\u0000\u0000\u0005%\u0001\u0000\u0000\u0000\u0007"+
		"\'\u0001\u0000\u0000\u0000\t.\u0001\u0000\u0000\u0000\u000b4\u0001\u0000"+
		"\u0000\u0000\r9\u0001\u0000\u0000\u0000\u000fT\u0001\u0000\u0000\u0000"+
		"\u0011{\u0001\u0000\u0000\u0000\u0013\u008b\u0001\u0000\u0000\u0000\u0015"+
		"\u00a9\u0001\u0000\u0000\u0000\u0017\u00ac\u0001\u0000\u0000\u0000\u0019"+
		"\u001a\u0005;\u0000\u0000\u001a\u0002\u0001\u0000\u0000\u0000\u001b\u001c"+
		"\u0005t\u0000\u0000\u001c\u001d\u0005u\u0000\u0000\u001d\u001e\u0005r"+
		"\u0000\u0000\u001e\u001f\u0005n\u0000\u0000\u001f\u0004\u0001\u0000\u0000"+
		"\u0000 !\u0005o\u0000\u0000!&\u0005n\u0000\u0000\"#\u0005o\u0000\u0000"+
		"#$\u0005f\u0000\u0000$&\u0005f\u0000\u0000% \u0001\u0000\u0000\u0000%"+
		"\"\u0001\u0000\u0000\u0000&\u0006\u0001\u0000\u0000\u0000\'(\u0005u\u0000"+
		"\u0000()\u0005p\u0000\u0000)*\u0005d\u0000\u0000*+\u0005a\u0000\u0000"+
		"+,\u0005t\u0000\u0000,-\u0005e\u0000\u0000-\b\u0001\u0000\u0000\u0000"+
		"./\u0005s\u0000\u0000/0\u0005t\u0000\u000001\u0005a\u0000\u000012\u0005"+
		"r\u0000\u000023\u0005t\u0000\u00003\n\u0001\u0000\u0000\u000045\u0005"+
		"i\u0000\u000056\u0005 \u0000\u000067\u0005a\u0000\u000078\u0005m\u0000"+
		"\u00008\f\u0001\u0000\u0000\u00009:\u0005i\u0000\u0000:;\u0005t\u0000"+
		"\u0000;<\u0005 \u0000\u0000<=\u0005i\u0000\u0000=>\u0005s\u0000\u0000"+
		">\u000e\u0001\u0000\u0000\u0000?@\u0005l\u0000\u0000@A\u0005i\u0000\u0000"+
		"AB\u0005g\u0000\u0000BC\u0005h\u0000\u0000CU\u0005t\u0000\u0000DE\u0005"+
		"h\u0000\u0000EF\u0005e\u0000\u0000FG\u0005a\u0000\u0000GH\u0005t\u0000"+
		"\u0000HI\u0005e\u0000\u0000IU\u0005r\u0000\u0000JK\u0005a\u0000\u0000"+
		"KL\u0005i\u0000\u0000LM\u0005r\u0000\u0000MN\u0005c\u0000\u0000NU\u0005"+
		"o\u0000\u0000OP\u0005d\u0000\u0000PQ\u0005o\u0000\u0000QR\u0005o\u0000"+
		"\u0000RS\u0005r\u0000\u0000SU\u0005s\u0000\u0000T?\u0001\u0000\u0000\u0000"+
		"TD\u0001\u0000\u0000\u0000TJ\u0001\u0000\u0000\u0000TO\u0001\u0000\u0000"+
		"\u0000U\u0010\u0001\u0000\u0000\u0000VW\u0005c\u0000\u0000WX\u0005o\u0000"+
		"\u0000XY\u0005f\u0000\u0000YZ\u0005f\u0000\u0000Z[\u0005e\u0000\u0000"+
		"[\\\u0005e\u0000\u0000\\]\u0005m\u0000\u0000]^\u0005a\u0000\u0000^_\u0005"+
		"c\u0000\u0000_`\u0005h\u0000\u0000`a\u0005i\u0000\u0000ab\u0005n\u0000"+
		"\u0000b|\u0005e\u0000\u0000cd\u0005d\u0000\u0000de\u0005i\u0000\u0000"+
		"ef\u0005s\u0000\u0000fg\u0005h\u0000\u0000gh\u0005w\u0000\u0000hi\u0005"+
		"a\u0000\u0000ij\u0005s\u0000\u0000jk\u0005h\u0000\u0000kl\u0005e\u0000"+
		"\u0000l|\u0005r\u0000\u0000mn\u0005w\u0000\u0000no\u0005a\u0000\u0000"+
		"op\u0005s\u0000\u0000pq\u0005h\u0000\u0000qr\u0005i\u0000\u0000rs\u0005"+
		"n\u0000\u0000st\u0005g\u0000\u0000tu\u0005m\u0000\u0000uv\u0005a\u0000"+
		"\u0000vw\u0005c\u0000\u0000wx\u0005h\u0000\u0000xy\u0005i\u0000\u0000"+
		"yz\u0005n\u0000\u0000z|\u0005e\u0000\u0000{V\u0001\u0000\u0000\u0000{"+
		"c\u0001\u0000\u0000\u0000{m\u0001\u0000\u0000\u0000|\u0012\u0001\u0000"+
		"\u0000\u0000}~\u0005c\u0000\u0000~\u007f\u0005o\u0000\u0000\u007f\u0080"+
		"\u0005l\u0000\u0000\u0080\u008c\u0005d\u0000\u0000\u0081\u0082\u0005h"+
		"\u0000\u0000\u0082\u0083\u0005o\u0000\u0000\u0083\u008c\u0005t\u0000\u0000"+
		"\u0084\u0085\u0005t\u0000\u0000\u0085\u0086\u0005h\u0000\u0000\u0086\u0087"+
		"\u0005i\u0000\u0000\u0087\u0088\u0005r\u0000\u0000\u0088\u0089\u0005s"+
		"\u0000\u0000\u0089\u008a\u0005t\u0000\u0000\u008a\u008c\u0005y\u0000\u0000"+
		"\u008b}\u0001\u0000\u0000\u0000\u008b\u0081\u0001\u0000\u0000\u0000\u008b"+
		"\u0084\u0001\u0000\u0000\u0000\u008c\u0014\u0001\u0000\u0000\u0000\u008d"+
		"\u008e\u0005m\u0000\u0000\u008e\u008f\u0005o\u0000\u0000\u008f\u0090\u0005"+
		"r\u0000\u0000\u0090\u0091\u0005n\u0000\u0000\u0091\u0092\u0005i\u0000"+
		"\u0000\u0092\u0093\u0005n\u0000\u0000\u0093\u00aa\u0005g\u0000\u0000\u0094"+
		"\u0095\u0005a\u0000\u0000\u0095\u0096\u0005f\u0000\u0000\u0096\u0097\u0005"+
		"t\u0000\u0000\u0097\u0098\u0005e\u0000\u0000\u0098\u0099\u0005r\u0000"+
		"\u0000\u0099\u009a\u0005n\u0000\u0000\u009a\u009b\u0005o\u0000\u0000\u009b"+
		"\u009c\u0005o\u0000\u0000\u009c\u00aa\u0005n\u0000\u0000\u009d\u009e\u0005"+
		"e\u0000\u0000\u009e\u009f\u0005v\u0000\u0000\u009f\u00a0\u0005e\u0000"+
		"\u0000\u00a0\u00a1\u0005n\u0000\u0000\u00a1\u00a2\u0005i\u0000\u0000\u00a2"+
		"\u00a3\u0005n\u0000\u0000\u00a3\u00aa\u0005g\u0000\u0000\u00a4\u00a5\u0005"+
		"n\u0000\u0000\u00a5\u00a6\u0005i\u0000\u0000\u00a6\u00a7\u0005g\u0000"+
		"\u0000\u00a7\u00a8\u0005h\u0000\u0000\u00a8\u00aa\u0005t\u0000\u0000\u00a9"+
		"\u008d\u0001\u0000\u0000\u0000\u00a9\u0094\u0001\u0000\u0000\u0000\u00a9"+
		"\u009d\u0001\u0000\u0000\u0000\u00a9\u00a4\u0001\u0000\u0000\u0000\u00aa"+
		"\u0016\u0001\u0000\u0000\u0000\u00ab\u00ad\u0007\u0000\u0000\u0000\u00ac"+
		"\u00ab\u0001\u0000\u0000\u0000\u00ad\u00ae\u0001\u0000\u0000\u0000\u00ae"+
		"\u00ac\u0001\u0000\u0000\u0000\u00ae\u00af\u0001\u0000\u0000\u0000\u00af"+
		"\u00b0\u0001\u0000\u0000\u0000\u00b0\u00b1\u0006\u000b\u0000\u0000\u00b1"+
		"\u0018\u0001\u0000\u0000\u0000\u0007\u0000%T{\u008b\u00a9\u00ae\u0001"+
		"\u0006\u0000\u0000";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}