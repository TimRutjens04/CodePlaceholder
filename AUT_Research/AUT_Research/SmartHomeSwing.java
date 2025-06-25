import javax.swing.*;
import java.awt.*;

public class SmartHomeSwing {
    public static void startUI(SmartHome home, SequenceManager seqManager) {
        JFrame frame = new JFrame("Smart Home GUI");
        HousePanel housePanel = new HousePanel(home);
        JTextField commandField = new JTextField();

        CommandProcessor processor = new CommandProcessor(home, seqManager);

        commandField.addActionListener(e -> {
            String cmd = commandField.getText();
            processor.runCommand(cmd);
            housePanel.repaint();  // Update the visuals
            commandField.setText("");
        });

        frame.setLayout(new BorderLayout());
        frame.add(housePanel, BorderLayout.CENTER);
        frame.add(new ConsolePanel(), BorderLayout.EAST);
        frame.add(commandField, BorderLayout.SOUTH);
        frame.setSize(1200, 1000);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}
