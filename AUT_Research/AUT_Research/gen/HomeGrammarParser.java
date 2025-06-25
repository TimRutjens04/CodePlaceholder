// Generated from HomeGrammar.g4 by ANTLR 4.13.2
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue", "this-escape"})
public class HomeGrammarParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.13.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, TURN=2, STATE=3, UPDATE=4, TASK=5, I_AM=6, IT_IS=7, DEVICE=8, 
		TASK_DEVICE=9, FEELING=10, TIME_OF_DAY=11, WS=12;
	public static final int
		RULE_prog = 0, RULE_command = 1;
	private static String[] makeRuleNames() {
		return new String[] {
			"prog", "command"
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

	@Override
	public String getGrammarFileName() { return "HomeGrammar.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public HomeGrammarParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@SuppressWarnings("CheckReturnValue")
	public static class ProgContext extends ParserRuleContext {
		public List<CommandContext> command() {
			return getRuleContexts(CommandContext.class);
		}
		public CommandContext command(int i) {
			return getRuleContext(CommandContext.class,i);
		}
		public ProgContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_prog; }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof HomeGrammarVisitor ) return ((HomeGrammarVisitor<? extends T>)visitor).visitProg(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ProgContext prog() throws RecognitionException {
		ProgContext _localctx = new ProgContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(4);
			command();
			setState(9);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,0,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					setState(5);
					match(T__0);
					setState(6);
					command();
					}
					} 
				}
				setState(11);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,0,_ctx);
			}
			setState(13);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==T__0) {
				{
				setState(12);
				match(T__0);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	@SuppressWarnings("CheckReturnValue")
	public static class CommandContext extends ParserRuleContext {
		public CommandContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_command; }
	 
		public CommandContext() { }
		public void copyFrom(CommandContext ctx) {
			super.copyFrom(ctx);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class UpdateDeviceCommandContext extends CommandContext {
		public TerminalNode UPDATE() { return getToken(HomeGrammarParser.UPDATE, 0); }
		public TerminalNode TIME_OF_DAY() { return getToken(HomeGrammarParser.TIME_OF_DAY, 0); }
		public TerminalNode DEVICE() { return getToken(HomeGrammarParser.DEVICE, 0); }
		public TerminalNode STATE() { return getToken(HomeGrammarParser.STATE, 0); }
		public TerminalNode TASK_DEVICE() { return getToken(HomeGrammarParser.TASK_DEVICE, 0); }
		public UpdateDeviceCommandContext(CommandContext ctx) { copyFrom(ctx); }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof HomeGrammarVisitor ) return ((HomeGrammarVisitor<? extends T>)visitor).visitUpdateDeviceCommand(this);
			else return visitor.visitChildren(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class FeelingCommandContext extends CommandContext {
		public TerminalNode I_AM() { return getToken(HomeGrammarParser.I_AM, 0); }
		public TerminalNode FEELING() { return getToken(HomeGrammarParser.FEELING, 0); }
		public FeelingCommandContext(CommandContext ctx) { copyFrom(ctx); }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof HomeGrammarVisitor ) return ((HomeGrammarVisitor<? extends T>)visitor).visitFeelingCommand(this);
			else return visitor.visitChildren(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class TurnDeviceCommandContext extends CommandContext {
		public TerminalNode TURN() { return getToken(HomeGrammarParser.TURN, 0); }
		public TerminalNode DEVICE() { return getToken(HomeGrammarParser.DEVICE, 0); }
		public TerminalNode STATE() { return getToken(HomeGrammarParser.STATE, 0); }
		public TurnDeviceCommandContext(CommandContext ctx) { copyFrom(ctx); }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof HomeGrammarVisitor ) return ((HomeGrammarVisitor<? extends T>)visitor).visitTurnDeviceCommand(this);
			else return visitor.visitChildren(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class TimeCommandContext extends CommandContext {
		public TerminalNode IT_IS() { return getToken(HomeGrammarParser.IT_IS, 0); }
		public TerminalNode TIME_OF_DAY() { return getToken(HomeGrammarParser.TIME_OF_DAY, 0); }
		public TimeCommandContext(CommandContext ctx) { copyFrom(ctx); }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof HomeGrammarVisitor ) return ((HomeGrammarVisitor<? extends T>)visitor).visitTimeCommand(this);
			else return visitor.visitChildren(this);
		}
	}
	@SuppressWarnings("CheckReturnValue")
	public static class TaskCommandContext extends CommandContext {
		public TerminalNode TASK() { return getToken(HomeGrammarParser.TASK, 0); }
		public TerminalNode TASK_DEVICE() { return getToken(HomeGrammarParser.TASK_DEVICE, 0); }
		public TaskCommandContext(CommandContext ctx) { copyFrom(ctx); }
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof HomeGrammarVisitor ) return ((HomeGrammarVisitor<? extends T>)visitor).visitTaskCommand(this);
			else return visitor.visitChildren(this);
		}
	}

	public final CommandContext command() throws RecognitionException {
		CommandContext _localctx = new CommandContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_command);
		try {
			setState(32);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case TASK:
				_localctx = new TaskCommandContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(15);
				match(TASK);
				setState(16);
				match(TASK_DEVICE);
				}
				break;
			case I_AM:
				_localctx = new FeelingCommandContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(17);
				match(I_AM);
				setState(18);
				match(FEELING);
				}
				break;
			case IT_IS:
				_localctx = new TimeCommandContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(19);
				match(IT_IS);
				setState(20);
				match(TIME_OF_DAY);
				}
				break;
			case TURN:
				_localctx = new TurnDeviceCommandContext(_localctx);
				enterOuterAlt(_localctx, 4);
				{
				setState(21);
				match(TURN);
				setState(22);
				match(DEVICE);
				setState(23);
				match(STATE);
				}
				break;
			case UPDATE:
				_localctx = new UpdateDeviceCommandContext(_localctx);
				enterOuterAlt(_localctx, 5);
				{
				setState(24);
				match(UPDATE);
				setState(25);
				match(TIME_OF_DAY);
				setState(30);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case DEVICE:
					{
					setState(26);
					match(DEVICE);
					setState(27);
					match(STATE);
					}
					break;
				case TASK_DEVICE:
					{
					setState(28);
					match(TASK_DEVICE);
					setState(29);
					match(STATE);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\u0004\u0001\f#\u0002\u0000\u0007\u0000\u0002\u0001\u0007\u0001\u0001"+
		"\u0000\u0001\u0000\u0001\u0000\u0005\u0000\b\b\u0000\n\u0000\f\u0000\u000b"+
		"\t\u0000\u0001\u0000\u0003\u0000\u000e\b\u0000\u0001\u0001\u0001\u0001"+
		"\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001"+
		"\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001\u0001"+
		"\u0001\u0001\u0003\u0001\u001f\b\u0001\u0003\u0001!\b\u0001\u0001\u0001"+
		"\u0000\u0000\u0002\u0000\u0002\u0000\u0000\'\u0000\u0004\u0001\u0000\u0000"+
		"\u0000\u0002 \u0001\u0000\u0000\u0000\u0004\t\u0003\u0002\u0001\u0000"+
		"\u0005\u0006\u0005\u0001\u0000\u0000\u0006\b\u0003\u0002\u0001\u0000\u0007"+
		"\u0005\u0001\u0000\u0000\u0000\b\u000b\u0001\u0000\u0000\u0000\t\u0007"+
		"\u0001\u0000\u0000\u0000\t\n\u0001\u0000\u0000\u0000\n\r\u0001\u0000\u0000"+
		"\u0000\u000b\t\u0001\u0000\u0000\u0000\f\u000e\u0005\u0001\u0000\u0000"+
		"\r\f\u0001\u0000\u0000\u0000\r\u000e\u0001\u0000\u0000\u0000\u000e\u0001"+
		"\u0001\u0000\u0000\u0000\u000f\u0010\u0005\u0005\u0000\u0000\u0010!\u0005"+
		"\t\u0000\u0000\u0011\u0012\u0005\u0006\u0000\u0000\u0012!\u0005\n\u0000"+
		"\u0000\u0013\u0014\u0005\u0007\u0000\u0000\u0014!\u0005\u000b\u0000\u0000"+
		"\u0015\u0016\u0005\u0002\u0000\u0000\u0016\u0017\u0005\b\u0000\u0000\u0017"+
		"!\u0005\u0003\u0000\u0000\u0018\u0019\u0005\u0004\u0000\u0000\u0019\u001e"+
		"\u0005\u000b\u0000\u0000\u001a\u001b\u0005\b\u0000\u0000\u001b\u001f\u0005"+
		"\u0003\u0000\u0000\u001c\u001d\u0005\t\u0000\u0000\u001d\u001f\u0005\u0003"+
		"\u0000\u0000\u001e\u001a\u0001\u0000\u0000\u0000\u001e\u001c\u0001\u0000"+
		"\u0000\u0000\u001f!\u0001\u0000\u0000\u0000 \u000f\u0001\u0000\u0000\u0000"+
		" \u0011\u0001\u0000\u0000\u0000 \u0013\u0001\u0000\u0000\u0000 \u0015"+
		"\u0001\u0000\u0000\u0000 \u0018\u0001\u0000\u0000\u0000!\u0003\u0001\u0000"+
		"\u0000\u0000\u0004\t\r\u001e ";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}