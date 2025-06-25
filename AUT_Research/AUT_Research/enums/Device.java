package enums;

public enum Device {
    LIGHT, AIRCO, HEATER, DOORS;

    public static Device fromString(String s) {
        return switch (s.toLowerCase()) {
            case "light" -> LIGHT;
            case "airco" -> AIRCO;
            case "heater" -> HEATER;
            case "doors" -> DOORS;
            default -> throw new IllegalArgumentException("Unknown device: " + s);
        };
    }
}

