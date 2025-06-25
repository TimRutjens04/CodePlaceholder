package enums;

public enum Feeling {
    COLD, HOT;

    public static Feeling fromString(String s) {
        return switch (s.toLowerCase()) {
            case "cold" -> COLD;
            case "hot" -> HOT;
            default -> throw new IllegalArgumentException("Unknown feeling: " + s);
        };
    }
}

