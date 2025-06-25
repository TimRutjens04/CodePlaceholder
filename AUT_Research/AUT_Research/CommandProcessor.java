
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.CharStreams;
import org.antlr.v4.runtime.CommonTokenStream;

public class CommandProcessor {
    private final HomeVisitorImpl visitor;

    public CommandProcessor(SmartHome home, SequenceManager seqManager) {
        this.visitor = new HomeVisitorImpl(home, seqManager);
    }

    public void runCommand(String inputText) {
        try {
            CharStream input = CharStreams.fromString(inputText);
            HomeGrammarLexer lexer = new HomeGrammarLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            HomeGrammarParser parser = new HomeGrammarParser(tokens);

            visitor.visit(parser.prog());  // Visit the command
        } catch (Exception e) {
            e.printStackTrace();  // Handle invalid grammar input
        }
    }
}
