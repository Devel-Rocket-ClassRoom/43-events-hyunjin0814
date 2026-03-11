using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class AchievementSystem
{
    public void Achievement(object sender, GameEventArgs e)
    {
        if (e.EventName == "Achievement")
        {
            Console.WriteLine($"업적 달성: {e.Data}");
        }
    }
}