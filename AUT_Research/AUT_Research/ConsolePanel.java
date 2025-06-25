import javax.swing.*;
import javax.swing.text.BadLocationException;
import java.awt.*;
import java.io.OutputStream;
import java.io.PrintStream;

public class ConsolePanel extends JPanel {
    private JTextArea logTextArea;
    private JScrollPane scrollPane;

    public ConsolePanel() {
        setLayout(new BorderLayout());
        setBackground(Color.DARK_GRAY);

        // Initialize the JTextArea for displaying logs
        logTextArea = new JTextArea(30, 70); // Rows, columns
        logTextArea.setEditable(false); // Make it read-only
        logTextArea.setBackground(new Color(40, 40, 40)); // Dark background
        logTextArea.setForeground(Color.LIGHT_GRAY); // Light text color
        logTextArea.setFont(new Font("Monospaced", Font.PLAIN, 12)); // Monospaced font for logs
        logTextArea.setLineWrap(true);   // Wrap lines
        logTextArea.setWrapStyleWord(true); // Wrap at word boundaries

        // Wrap the JTextArea in a JScrollPane to allow scrolling
        scrollPane = new JScrollPane(logTextArea);
        scrollPane.setVerticalScrollBarPolicy(JScrollPane.VERTICAL_SCROLLBAR_ALWAYS);
        scrollPane.setHorizontalScrollBarPolicy(JScrollPane.HORIZONTAL_SCROLLBAR_NEVER); // No horizontal scroll

        add(scrollPane, BorderLayout.CENTER);

        redirectSystemOut();
    }

    private void redirectSystemOut() {
        OutputStream textAreaStream = new OutputStream() {
            @Override
            public void write(int b) {
                // Append the character to the JTextArea
                logTextArea.append(String.valueOf((char) b));
                // Scroll to the bottom automatically
                logTextArea.setCaretPosition(logTextArea.getDocument().getLength());
            }

            @Override
            public void write(byte[] b, int off, int len) {
                // Append the byte array as a string to the JTextArea
                String text = new String(b, off, len);
                logTextArea.append(text);
                // Scroll to the bottom automatically
                logTextArea.setCaretPosition(logTextArea.getDocument().getLength());
            }
        };
        System.setOut(new PrintStream(textAreaStream, true)); // 'true' for auto-flush
    }

    public void clearLogs() {
        logTextArea.setText("");
    }

    public void appendLog(String message) {
        logTextArea.append(message + System.lineSeparator());
        logTextArea.setCaretPosition(logTextArea.getDocument().getLength());
    }
}
