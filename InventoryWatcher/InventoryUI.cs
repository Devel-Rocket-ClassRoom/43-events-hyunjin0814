using System;

class InventoryUI
{
    public void UpdateUI(string name, int oldCount, int newCount)
    {
        Console.WriteLine($"[UI] {name}: {oldCount} -> {newCount}");
    }
}