import enums.Device;
import enums.TaskDevice;
import enums.TimeOfDay;

import java.util.*;

public class SequenceManager {
    private final EnumMap<TimeOfDay, EnumMap<Device, Boolean>> deviceSequences = new EnumMap<>(TimeOfDay.class);
    private final EnumMap<TimeOfDay, EnumMap<TaskDevice, Boolean>> taskSequences = new EnumMap<>(TimeOfDay.class);

    public SequenceManager() {
        for (TimeOfDay time : TimeOfDay.values()) {
            deviceSequences.put(time, new EnumMap<>(Device.class));
            taskSequences.put(time, new EnumMap<>(TaskDevice.class));
        }

        morningSequence();
        afternoonSequence();
        eveningSequence();
        nightSequence();
    }

    public EnumMap<Device, Boolean> getDeviceSequence(TimeOfDay timeOfDay) {
        return deviceSequences.get(timeOfDay);
    }

    public EnumMap<TaskDevice, Boolean> getTaskSequence(TimeOfDay timeOfDay) {
        return taskSequences.get(timeOfDay);
    }

    public void changeDeviceSequence(TimeOfDay timeOfDay, Device device, boolean state) {
        deviceSequences.get(timeOfDay).put(device, state);
    }

    public void changeTaskSequence(TimeOfDay timeOfDay, TaskDevice task, boolean state) {
        taskSequences.get(timeOfDay).put(task, state);
    }

    private void morningSequence() {
        EnumMap<Device, Boolean> devices = deviceSequences.get(TimeOfDay.MORNING);
        devices.put(Device.LIGHT, true);
        devices.put(Device.AIRCO, false);
        devices.put(Device.HEATER, true);
        devices.put(Device.DOORS, false);

        EnumMap<TaskDevice, Boolean> tasks = taskSequences.get(TimeOfDay.MORNING);
        tasks.put(TaskDevice.COFFEEMACHINE, true);
    }

    private void afternoonSequence() {
        EnumMap<Device, Boolean> devices = deviceSequences.get(TimeOfDay.AFTERNOON);
        devices.put(Device.LIGHT, true);
        devices.put(Device.AIRCO, true);
        devices.put(Device.HEATER, false);
        devices.put(Device.DOORS, false);
    }

    private void eveningSequence() {
        EnumMap<Device, Boolean> devices = deviceSequences.get(TimeOfDay.EVENING);
        devices.put(Device.LIGHT, true);
        devices.put(Device.AIRCO, false);
        devices.put(Device.HEATER, true);
        devices.put(Device.DOORS, true);
    }

    private void nightSequence() {
        EnumMap<Device, Boolean> devices = deviceSequences.get(TimeOfDay.NIGHT);
        devices.put(Device.LIGHT, false);
        devices.put(Device.AIRCO, false);
        devices.put(Device.HEATER, false);
        devices.put(Device.DOORS, true);
    }
}
