using System;
using System.Collections.Generic;

class Inventory
{
    private Dictionary<string, int> dictionary;

    public event Action<string, int, int> ItemChanged;

    public Inventory()
    {
        dictionary = new Dictionary<string, int>();
    }

    public void AddItem(string name, int count)
    {
        int oldCount = 0;

        if (dictionary.ContainsKey(name))
        {
            oldCount = dictionary[name];
            dictionary[name] += count;
        }
        else
        {
            dictionary.Add(name, count);
        }
        ItemChanged?.Invoke(name, oldCount, dictionary[name]);
    }

    public void RemoveItem(string name, int count)
    {
        int oldCount = dictionary[name];

        dictionary[name] -= count;

        if (dictionary[name] < 0)
        {
            dictionary[name] = 0;
        }

        ItemChanged?.Invoke(name, oldCount, dictionary[name]);
    }
}