
import enums.Device;
import enums.TaskDevice;
import enums.TimeOfDay;

import java.util.EnumMap;

public class SmartHome {
    private boolean lightOn = false;
    private boolean heaterOn = false;
    private boolean aircoOn = false;
    private boolean doorsLocked = false;
    private final SequenceManager sequenceManager;
    private volatile boolean coffeeMachineActive = false;
    private volatile boolean washingMachineActive = false;
    private volatile boolean dishwasherActive = false;

    public SmartHome() {
        this.sequenceManager = new SequenceManager();
    }

    public void setDeviceState(Device device, boolean state) {
        switch (device) {
            case LIGHT -> lightOn = state;
            case HEATER -> heaterOn = state;
            case AIRCO -> aircoOn = state;
            case DOORS -> doorsLocked = state;
            default -> throw new IllegalArgumentException("Unknown device: " + device);
        }
        System.out.println("Setting " + device + " to " + (state ? "ON" : "OFF"));
    }

    public void changeDeviceSequence(TimeOfDay timeOfDay, Device device, boolean state) {
        sequenceManager.changeDeviceSequence(timeOfDay, device, state);
    }

    public void changeTaskSequence(TimeOfDay timeOfDay, TaskDevice task, boolean state) {
        sequenceManager.changeTaskSequence(timeOfDay, task, state);
        System.out.println("Updated task sequence for " + task + " at " + timeOfDay + " to " + (state ? "ON" : "OFF"));
    }

    public void runSequence(TimeOfDay timeOfDay) {
        EnumMap<Device, Boolean> deviceSequence = sequenceManager.getDeviceSequence(timeOfDay);
        for (var entry : deviceSequence.entrySet()) {
            setDeviceState(entry.getKey(), entry.getValue());
        }

        EnumMap<TaskDevice, Boolean> taskSequence = sequenceManager.getTaskSequence(timeOfDay);
        for (var entry : taskSequence.entrySet()) {
            if (entry.getValue()) {
                switch (entry.getKey()) {
                    case COFFEEMACHINE -> makeCoffee();
                    case DISHWASHER -> startDishwasher();
                    case WASHINGMACHINE -> washClothes();
                }
            }
        }
    }

    public void makeCoffee() {
        if (coffeeMachineActive) {
            System.out.println("Coffee machine is already brewing.");
            return;
        }
        coffeeMachineActive = true;
        System.out.println("Making coffee...");
    }

    public void washClothes() {
        if (washingMachineActive) {
            System.out.println("Washing machine is already running.");
            return;
        }
        washingMachineActive = true;
        System.out.println("Starting washing machine...");
    }

    public void startDishwasher() {
        if (dishwasherActive) {
            System.out.println("Dishwasher is already running.");
            return;
        }
        dishwasherActive = true;
        System.out.println("Starting dishwasher...");
    }

    public void printStatus() {
        System.out.println("Smart Home Status:");
        System.out.println("Light: " + (lightOn ? "On" : "Off"));
        System.out.println("Airco: " + (aircoOn ? "On" : "Off"));
        System.out.println("Heater: " + (heaterOn ? "On" : "Off"));
        System.out.println("Doors: " + (doorsLocked ? "Locked" : "Unlocked"));
    }
    public void setCoffeeMachineActive(boolean active) {
        this.coffeeMachineActive = active;
        if (!active) {
            System.out.println("Coffee is ready!");
        }
    }
    public void setWashingMachineActive(boolean active) {
        this.washingMachineActive = active;
        if (!active) {
            System.out.println("Washing machine cycle completed!");
        }
    }
    public void setDishwasherActive(boolean active) {
        this.dishwasherActive = active;
        if (!active) {
            System.out.println("Dishwasher cycle completed!");
        }
    }

    public boolean isCoffeeMachineActive() {
        return coffeeMachineActive;
    }
    public boolean isWashingMachineActive() {
        return washingMachineActive;
    }
    public boolean isDishwasherActive() {
        return dishwasherActive;
    }
}
