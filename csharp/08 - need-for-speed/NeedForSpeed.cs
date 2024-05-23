using System;

class RemoteControlCar
{
    private int carSpeed;
    private int batteryDrain;
    private int distanceDriven;
    private int battery = 100;

    public RemoteControlCar(int carSpeed, int batteryDrain)
    {
        this.carSpeed = carSpeed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => batteryDrain > battery;

    public int DistanceDriven() => distanceDriven;

    public void Drive()
    {
        if (!BatteryDrained)
        {
            distanceDriven += carSpeed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int trackDistance;

    public RaceTrack(int trackDistance)
    {
        this.trackDistance = trackDistance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained)
        {
            car.Drive();
        }

        return car.DistanceDriven >= trackDistance ? true : false;
    }
}
