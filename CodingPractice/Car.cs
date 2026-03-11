using System;

class Car
{
    private int fuelLevel;

    public event EventHandler<FuelEventArgs> FuelLow;
    public event Action<int> FuelChanged;

    public Car(int initialFuel)
    {
        fuelLevel = initialFuel; 
    }

    public int FuelLevel => fuelLevel;

    public void Drive()
    {
        if (fuelLevel <= 0)
        {
            Console.WriteLine("연료 없음! 운전 불가");
            return;
        }

        fuelLevel -= 10;
        Console.WriteLine($"운전 중... 연료: {fuelLevel}%");

        FuelChanged?.Invoke(fuelLevel);

        if (fuelLevel <= 0)
        {
            OnFuelLow(new FuelEventArgs(fuelLevel, "연료가 바닥났습니다!"));
        }
        else if (fuelLevel <= 20)
        {
            OnFuelLow(new FuelEventArgs(fuelLevel, "연료가 부족합니다"));
        }
    }
    protected virtual void OnFuelLow(FuelEventArgs e)
    { 
         FuelLow?.Invoke(this, e);
    }
}