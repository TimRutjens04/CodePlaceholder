import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.EnumMap;

import enums.Device;
import enums.TaskDevice;

public class HousePanel extends JPanel {
    private final SmartHome smartHome;
    private static final int width = 500;
    private static final int height = 500;
    private static final int borderWidth = 10;
    private static final int offset = 100 + borderWidth;
    private boolean fanIsHorizontal = true;
    private boolean heaterWaveActivePhase = true;
    private EnumMap<TaskDevice, Long> taskAnimationStartTimes;
    private EnumMap<TaskDevice, Integer> taskShakeOffsets;
    private static final long COFFEE_SHAKE_DURATION = 2000;
    private static final long WASHING_MACHINE_SHAKE_DURATION = 3000;
    private static final long DISHWASHER_SHAKE_DURATION = 4000;
    private Timer animationTimer;
    private Timer taskAnimationTimer;
    public HousePanel(SmartHome smartHome) {
        this.smartHome = smartHome;
        taskAnimationStartTimes = new EnumMap<>(TaskDevice.class);
        taskShakeOffsets = new EnumMap<>(TaskDevice.class);
        for (TaskDevice td : TaskDevice.values()) {
            taskAnimationStartTimes.put(td, 0L);
            taskShakeOffsets.put(td, 0);
        }
        initializeAnimationTimer();
        initializeTaskAnimationTimer();
    }
    private void initializeAnimationTimer() {
        animationTimer = new Timer(100, new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

                if (smartHomeIs(Device.AIRCO)) {fanIsHorizontal = !fanIsHorizontal;}
                if (smartHomeIs(Device.HEATER)) {heaterWaveActivePhase = !heaterWaveActivePhase;}
                repaint();
            }
        });
        animationTimer.start();
    }
    private void initializeTaskAnimationTimer() {
        // Task device animation runs faster for smoother shaking (e.g., 50ms)
        taskAnimationTimer = new Timer(50, new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                boolean anyTaskActive = false; // Flag to check if any task is active

                for (TaskDevice currentTaskDevice : TaskDevice.values()) {
                    // Check if the current task device is active according to SmartHome
                    boolean isTaskDeviceActive = smartHomeIsTaskDevice(currentTaskDevice);

                    if (isTaskDeviceActive) {
                        anyTaskActive = true; // At least one task is active

                        // Get or initialize animation start time for this device
                        long startTime = taskAnimationStartTimes.get(currentTaskDevice);
                        if (startTime == 0) {
                            taskAnimationStartTimes.put(currentTaskDevice, System.currentTimeMillis());
                            startTime = System.currentTimeMillis(); // Update local variable for current cycle
                        }

                        long elapsedTime = System.currentTimeMillis() - startTime;
                        long duration = getShakeDuration(currentTaskDevice);

                        if (elapsedTime < duration) {
                            // Continue shaking if duration not passed
                            int currentOffset = taskShakeOffsets.get(currentTaskDevice);
                            // Cycle through shake offsets (0 -> 2 -> 0 -> -2 -> 0...)
                            if (currentOffset == 0) taskShakeOffsets.put(currentTaskDevice, 2);
                            else if (currentOffset == 2) taskShakeOffsets.put(currentTaskDevice, -2);
                            else if (currentOffset == -2) taskShakeOffsets.put(currentTaskDevice, 0);
                        } else {
                            // Animation duration passed, stop shaking and reset state for this device
                            taskShakeOffsets.put(currentTaskDevice, 0); // Reset shake offset
                            taskAnimationStartTimes.put(currentTaskDevice, 0L); // Reset start time

                            // Signal SmartHome that the task's animation is complete
                            setSmartHomeTaskActive(currentTaskDevice, false); // Use the new setter
                        }
                    } else {
                        // If SmartHome reports task is not active, ensure its animation state is reset
                        taskShakeOffsets.put(currentTaskDevice, 0);
                        taskAnimationStartTimes.put(currentTaskDevice, 0L);
                    }
                }

                // Only stop the timer if no tasks are active AND the timer is currently running
                if (!anyTaskActive && taskAnimationTimer.isRunning()) {
                    taskAnimationTimer.stop();
                }

                repaint(); // Request a repaint to update the UI for all task devices
            }
        });
        // The taskAnimationTimer will be started/stopped on demand from paintComponent
    }
    private long getShakeDuration(TaskDevice device) {
        return switch (device) {
            case COFFEEMACHINE -> COFFEE_SHAKE_DURATION;
            case WASHINGMACHINE -> WASHING_MACHINE_SHAKE_DURATION;
            case DISHWASHER -> DISHWASHER_SHAKE_DURATION;
        };
    }
    private void setSmartHomeTaskActive(TaskDevice device, boolean active) {
        switch (device) {
            case COFFEEMACHINE -> smartHome.setCoffeeMachineActive(active);
            case WASHINGMACHINE -> smartHome.setWashingMachineActive(active);
            case DISHWASHER -> smartHome.setDishwasherActive(active);
        }
    }
    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);

        Color backgroundColor = smartHomeIs(Device.LIGHT) ? Color.LIGHT_GRAY : Color.DARK_GRAY;

        // Draw a simple house layout
        g.setColor(Color.BLACK);
        g.fillRect(offset - borderWidth, offset - borderWidth, width + (borderWidth * 2), height + (borderWidth * 2));
        g.setColor(backgroundColor);
        g.fillRect(offset, offset, width, height);

        // Draw devices based on SmartHome state
        drawBed(g);
        drawDoor(g, smartHomeIs(Device.DOORS), backgroundColor);
        drawFan(g, smartHomeIs(Device.AIRCO));
        drawHeater(g, smartHomeIs(Device.HEATER));
        drawCounter(g);
        drawCoffeeMachine(g);
        drawWashingMachine(g);
        drawDishwasher(g);

        boolean anyTaskDeviceIsActive = false;
        for (TaskDevice td : TaskDevice.values()) {
            if (smartHomeIsTaskDevice(td)) {
                anyTaskDeviceIsActive = true;
                break;
            }
        }
        if (anyTaskDeviceIsActive && !taskAnimationTimer.isRunning()) {
            taskAnimationTimer.start();
        }
    }
    private void drawDoor(Graphics g, boolean on, Color bg) {
        int doorWidth = 100;
        int doorHeight = 10;
        g.setColor(on ? Color.ORANGE : bg);
        g.fillRect(offset, offset + height, doorWidth, doorHeight);
    }
    private void drawBed(Graphics g) {
        int bedWidth = 150;
        int pillowHeight = 30;
        int sheetHeight = 200;
        g.setColor(Color.WHITE);
        g.fillRect(offset, offset, bedWidth, pillowHeight);
        g.setColor(Color.RED);
        g.fillRect(offset, offset + pillowHeight, bedWidth, sheetHeight);
    }
    private void drawFan(Graphics g, boolean aircoOn) {
        int circleSize = 30;
        int fanWidth = 100;
        int fanHeight = 20;

        int centerX = offset + width / 2;
        int centerY = offset + height / 2;

        g.setColor(Color.BLACK);
        g.fillOval(centerX - circleSize / 2, centerY - circleSize / 2, circleSize, circleSize);

        g.setColor(Color.BLACK); // Fan blades are always black

        if (aircoOn) {
            if (fanIsHorizontal) {
                g.fillRect(centerX - fanWidth / 2, centerY - fanHeight / 2, fanWidth, fanHeight);
            } else {
                g.fillRect(centerX - fanHeight / 2, centerY - fanWidth / 2, fanHeight, fanWidth);
            }
        } else {
            if (fanIsHorizontal) {
                g.fillRect(centerX - fanWidth / 2, centerY - fanHeight / 2, fanWidth, fanHeight);
            } else {
                g.fillRect(centerX - fanHeight / 2, centerY - fanWidth / 2, fanHeight, fanWidth);
            }
        }
    }
    private void drawHeater(Graphics g, boolean heaterOn) {
        int heaterWidth = 80;
        int heaterHeight = 30;
        int heaterX = offset + width / 2 - heaterWidth / 2;
        int heaterY = offset + height - heaterHeight;


        // Draw the main heater body (white rectangle)
        g.setColor(Color.WHITE);
        g.fillRect(heaterX, heaterY, heaterWidth, heaterHeight);

        if (heaterOn) {
            // Draw heat waves if the heater is on
            g.setColor(Color.ORANGE); // Heat wave color

            if (heaterWaveActivePhase) {
                // Pattern 1: A few arcs slightly offset
                g.drawArc(heaterX + 5, heaterY - 15, heaterWidth / 2, 50, 45, 90);
                g.drawArc(heaterX + heaterWidth / 2, heaterY - 25, heaterWidth / 2, 50, 45, 90);
            } else {
                // Pattern 2: Slightly different arcs for the alternating effect
                g.drawArc(heaterX, heaterY - 20, heaterWidth / 2, 50, 45, 90);
                g.drawArc(heaterX + heaterWidth / 2 - 5, heaterY - 30, heaterWidth / 2, 50, 45, 90);
                g.drawArc(heaterX + 10, heaterY - 40, heaterWidth / 2, 50, 45, 90);
            }
        }
    }
    private void drawCounter(Graphics g) {
        int counterWidth = 100;
        int counter1Width = 250;
        int counter2Height = 300;
        g.setColor(Color.WHITE);
        g.fillRect(offset + width / 2, offset, counter1Width, counterWidth);
        g.fillRect(offset + width - counterWidth, offset + counterWidth, counterWidth, counter2Height);
    }
    private void drawCoffeeMachine(Graphics g) {
        int machineWidth = 30;
        int machineHeight = 50;
        int currentMachineX = offset + width / 2 + machineWidth;
        currentMachineX += taskShakeOffsets.get(TaskDevice.COFFEEMACHINE);
        int machineY = offset + machineHeight / 2;

        g.setColor(Color.DARK_GRAY.brighter());
        g.fillRect(currentMachineX, machineY, machineWidth, machineHeight);
        g.setColor(Color.BLACK);
        g.drawRect(currentMachineX, machineY, machineWidth, machineHeight); // Border
    }
    private void drawWashingMachine(Graphics g) {
        int wmWidth = 100;
        int wmHeight = 100;
        // Position the washing machine (e.g., near the bed)
        int currentWmX = offset + width - wmWidth; // Near bed
        currentWmX += taskShakeOffsets.get(TaskDevice.WASHINGMACHINE); // Apply shake offset
        int wmY = offset + height - wmHeight * 2; // Bottom left corner

        g.setColor(Color.LIGHT_GRAY);
        g.fillRect(currentWmX, wmY, wmWidth, wmHeight);
        g.setColor(Color.BLACK);
        g.drawRect(currentWmX, wmY, wmWidth, wmHeight); // Body
        g.drawOval(currentWmX + wmWidth / 4, wmY + wmWidth / 4, wmWidth / 2, wmWidth / 2); // Circular door/drum
    }
    private void drawDishwasher(Graphics g) {
        int dwWidth = 100;
        int dwHeight = 100;

        int currentDwX = offset + width - dwWidth;
        currentDwX += taskShakeOffsets.get(TaskDevice.DISHWASHER);
        int dwY = offset + dwHeight;

        g.setColor(Color.GRAY);
        g.fillRect(currentDwX, dwY, dwWidth, dwHeight);
        g.setColor(Color.BLACK);
        g.drawRect(currentDwX, dwY, dwWidth, dwHeight); // Body
        g.drawRect(currentDwX + 10, dwY + 10, 10, dwHeight - 20); // Handle
    }
    private boolean smartHomeIs(Device device) {
        // Use the SmartHome's printStatus fields, indirectly exposed here
        return switch (device) {
            case LIGHT -> getField("lightOn");
            case HEATER ->  getField("heaterOn");
            case AIRCO -> getField("aircoOn");
            case DOORS -> getField("doorsLocked");
            default -> false;
        };
    }
    private boolean smartHomeIsTaskDevice(TaskDevice taskDevice) {
        // Use direct getters from SmartHome for better encapsulation and readability
        return switch (taskDevice) {
            case COFFEEMACHINE -> smartHome.isCoffeeMachineActive();
            case WASHINGMACHINE -> smartHome.isWashingMachineActive();
            case DISHWASHER -> smartHome.isDishwasherActive();
        };
    }
    private boolean getField(String fieldName) {
        try {
            var field = smartHome.getClass().getDeclaredField(fieldName);
            field.setAccessible(true);
            return field.getBoolean(smartHome);
        } catch (Exception e) {
            return false;
        }
    }
}
