using System;

class FuelEventArgs : EventArgs
{
    public int FuelLevel { get; }
    public string Warning { get; }

    public FuelEventArgs(int level, string warning)
    {
        FuelLevel = level; Warning = warning;
    }
}