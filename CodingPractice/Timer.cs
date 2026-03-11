using System;

class Timer
{
    private int time;

    public event Action Tick;

    public void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            time++;
            Console.WriteLine($"타이머: {time}초");
            Tick?.Invoke();
        }
    }
}