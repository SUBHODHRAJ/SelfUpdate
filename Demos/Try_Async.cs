using System;

class Program
{
    public static async Task OnlineClass(CancellationToken token)
    {
        for (int i = 1; i <= 60; i++)
        {
            token.ThrowIfCancellationRequested();
            Console.WriteLine("Online class running for " + i + " minutes");
            await Task.Delay(1000,token);
        }

        Console.WriteLine("Online class completed");
    }

    public static async Task Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        Console.WriteLine("Online class started");
        Console.WriteLine("Press C to cancel the online class");
        Task key = Task.Run(() =>
        {
            while (!cts.IsCancellationRequested)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.L || keyInfo.Key == ConsoleKey.C)
                    {
                        cts.Cancel();
                        break;
                    }
                }
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