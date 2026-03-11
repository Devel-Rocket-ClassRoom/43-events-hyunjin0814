using System;

static class EventManager
{
    public static event EventHandler<GameEventArgs> OnGameEvent;

    public static void TriggerEvent(string eventName, object data = null)
    {
        OnGameEvent?.Invoke(eventName, new GameEventArgs(eventName, data));
    }

}

// TriggerEvent에 어떤 이벤트가 발생해도 SoundSystem