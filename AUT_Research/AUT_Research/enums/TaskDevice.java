package enums;

public enum TaskDevice {
    COFFEEMACHINE, WASHINGMACHINE, DISHWASHER;

    public static TaskDevice fromString(String s) {
        return switch (s.toLowerCase()) {
            case "coffeemachine" -> COFFEEMACHINE;
            case "washingmachine" -> WASHINGMACHINE;
            case "dishwasher" -> DISHWASHER;
            default -> throw new IllegalArgumentException("Unknown action device: " + s);
        };
    }
}
