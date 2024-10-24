using System;

class RemoteControlCar
{
    private  int _distanceTravelled = 0;
    private int _batteryLevel = 100;

    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distanceTravelled} meters";

    public string BatteryDisplay() => _batteryLevel > 0 ? $"Battery at {_batteryLevel}%" : "Battery empty";

    public void Drive()
    {
        if (_batteryLevel > 0)
        {
            _distanceTravelled += 20;
            _batteryLevel -= 1;
        }
    }
}
