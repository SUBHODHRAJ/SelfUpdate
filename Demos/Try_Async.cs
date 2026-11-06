using System;

class Program
{
    public static async Task OnlineClass(CancellationToken token)
    {
        for (int i = 1; i <= 10; i++)
        {
            token.ThrowIfCancellationRequested();

            Console.WriteLine("Online class running... " + i);

            await Task.Delay(2000,token);
        }

        Console.WriteLine("Online class completed");
    }

    public static async Task Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();

        Console.WriteLine("Online class started");
        Console.WriteLine("Press L to apply leave");

        Task key = Task.Run(() =>
        {
            if (Console.ReadKey(true).Key == ConsoleKey.L)
            {
                cts.Cancel();
            }
        });

        try
        {
            await OnlineClass(cts.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Leave Approved!");
            Console.WriteLine("Online class cancelled");
        }

        cts.Dispose();
    }
}