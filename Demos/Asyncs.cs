using System;

class AsyncDemo
{
    public static async Task MovieDownload()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Downloading movie... {i * 10}%");
            await Task.Delay(1000);
        }
        Console.WriteLine("Movie download completed!");
    }

    public static async Task Main(string[] args)
    {
        Console.WriteLine("Movie started to download");
        await MovieDownload();
    }
}