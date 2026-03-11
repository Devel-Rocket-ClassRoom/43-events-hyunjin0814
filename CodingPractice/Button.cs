class Button
{
    public event EventHandler Click;

    public void Onclick()
    {
        Click?.Invoke();
    }
}