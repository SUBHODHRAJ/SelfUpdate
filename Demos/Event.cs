using System;

public delegate void ButtonClick();

class Button
{
    public event ButtonClick? OnClick;

    public void ClickButton()
    {
        Console.WriteLine("Button clicked!");
        TriggerClick();
    }

    public void TriggerClick()
    {
        Console.WriteLine("Triggering button click event...");

        OnClick?.Invoke();
    }

    static void Main(string[] args)
    {
        Button btn = new Button();

        btn.OnClick += () =>
        {
            Console.WriteLine("Event executed!");
        };
        btn.ClickButton();
        
        Console.WriteLine("Clicking the button...");
        
    }
}