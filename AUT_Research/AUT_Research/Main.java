import javax.swing.*;

public class Main {
    public static void main(String[] args) {
        // Shared model
        SmartHome home = new SmartHome();
        SequenceManager sequenceManager = new SequenceManager();

        // Start GUI and pass model + logic
        SwingUtilities.invokeLater(() -> SmartHomeSwing.startUI(home, sequenceManager));
    }
}
