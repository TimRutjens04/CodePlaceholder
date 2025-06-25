import enums.TaskDevice;
import enums.Device;
import enums.Feeling;
import enums.TimeOfDay;

public class HomeVisitorImpl extends HomeGrammarBaseVisitor<Void> {
    private final SmartHome home;

    public HomeVisitorImpl(SmartHome home, SequenceManager sm) {
        this.home = home;
    }

    @Override
    public Void visitTaskCommand(HomeGrammarParser.TaskCommandContext ctx) {
        String stateText = ctx.TASK().getText();
        switch (TaskDevice.fromString(ctx.TASK_DEVICE().getText())){
            case COFFEEMACHINE:
                if ("start".equalsIgnoreCase(stateText))
                    home.makeCoffee();
                else
                    System.out.println("Coffee machine is already off.");
                break;
            case WASHINGMACHINE:
                if ("start".equalsIgnoreCase(stateText)) {
                    home.washClothes();
                } else {
                    System.out.println("Washing machine is already off.");
                }
                break;
            case DISHWASHER:
                if ("start".equalsIgnoreCase(stateText)) {
                    home.startDishwasher();
                } else {
                    System.out.println("Dishwasher is already off.");
                }
                break;
        }
        return null;
    }

    @Override
    public Void visitFeelingCommand(HomeGrammarParser.FeelingCommandContext ctx) {
        switch (Feeling.fromString(ctx.FEELING().getText())) {
            case COLD:
                home.setDeviceState(Device.AIRCO, false);
                home.setDeviceState(Device.HEATER, true);
                break;
            case HOT:
                home.setDeviceState(Device.AIRCO, true);
                home.setDeviceState(Device.HEATER, false);
                break;
            default:
                System.out.println("No specific action for feeling: " + ctx.FEELING().getText());
                break;
        }
        return null;
    }

    @Override
    public Void visitTimeCommand(HomeGrammarParser.TimeCommandContext ctx) {
        home.runSequence(TimeOfDay.fromString(ctx.TIME_OF_DAY().getText()));
        return null;
    }

    @Override
    public Void visitTurnDeviceCommand(HomeGrammarParser.TurnDeviceCommandContext ctx) {
        String deviceName = ctx.DEVICE().getText();
        String stateText = ctx.STATE().getText();
        Device device = Device.fromString(deviceName);

        if (device != null) {
            home.setDeviceState(device, ("on").equalsIgnoreCase(stateText));
        } else {
            System.out.println("Unknown device: " + deviceName);
        }
        return null;
    }

    @Override
    public Void visitUpdateDeviceCommand(HomeGrammarParser.UpdateDeviceCommandContext ctx) {
        Device device = ctx.DEVICE() != null ? Device.fromString(ctx.DEVICE().getText()) : null;
        TaskDevice taskDevice = ctx.TASK_DEVICE() != null ? TaskDevice.fromString(ctx.TASK_DEVICE().getText()) : null;
        TimeOfDay timeOfDay = TimeOfDay.fromString(ctx.TIME_OF_DAY().getText());
        boolean state = ("on").equalsIgnoreCase(ctx.STATE().getText());

        if (device != null) {
            home.changeDeviceSequence(timeOfDay, device, state);
        } if (taskDevice != null) {
            home.changeTaskSequence(timeOfDay, taskDevice, state);
        } else{
            System.out.println("Unknown device");
        }
        return null;
    }
}
