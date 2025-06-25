// Generated from HomeGrammar.g4 by ANTLR 4.13.2
import org.antlr.v4.runtime.tree.ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link HomeGrammarParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */
public interface HomeGrammarVisitor<T> extends ParseTreeVisitor<T> {
	/**
	 * Visit a parse tree produced by {@link HomeGrammarParser#prog}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitProg(HomeGrammarParser.ProgContext ctx);
	/**
	 * Visit a parse tree produced by the {@code TaskCommand}
	 * labeled alternative in {@link HomeGrammarParser#command}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTaskCommand(HomeGrammarParser.TaskCommandContext ctx);
	/**
	 * Visit a parse tree produced by the {@code FeelingCommand}
	 * labeled alternative in {@link HomeGrammarParser#command}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitFeelingCommand(HomeGrammarParser.FeelingCommandContext ctx);
	/**
	 * Visit a parse tree produced by the {@code TimeCommand}
	 * labeled alternative in {@link HomeGrammarParser#command}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTimeCommand(HomeGrammarParser.TimeCommandContext ctx);
	/**
	 * Visit a parse tree produced by the {@code TurnDeviceCommand}
	 * labeled alternative in {@link HomeGrammarParser#command}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTurnDeviceCommand(HomeGrammarParser.TurnDeviceCommandContext ctx);
	/**
	 * Visit a parse tree produced by the {@code UpdateDeviceCommand}
	 * labeled alternative in {@link HomeGrammarParser#command}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitUpdateDeviceCommand(HomeGrammarParser.UpdateDeviceCommandContext ctx);
}