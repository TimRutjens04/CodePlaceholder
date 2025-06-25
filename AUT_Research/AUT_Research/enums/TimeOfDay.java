package enums;

public enum TimeOfDay {
    MORNING, AFTERNOON, EVENING, NIGHT;

    public static TimeOfDay fromString(String s) {
        return switch (s.toLowerCase()) {
            case "morning" -> MORNING;
            case "afternoon" -> AFTERNOON;
            case "evening" -> EVENING;
            case "night" -> NIGHT;
            default -> throw new IllegalArgumentException("Unknown time: " + s);
        };
    }
}

