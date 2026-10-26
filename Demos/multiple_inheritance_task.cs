using System;
interface INetflix
{
    void WatchMovie(string name);
    void DownloadMovie(string name);
}
interface IAmazonPrime
{
    void WatchMovie(string name);
    void DownloadMovie(string name);
}

interface IDisneyPlus
{
    void WatchMovie(string name);
    void DownloadMovie(string name);
}

class OTT : INetflix, IAmazonPrime, IDisneyPlus
{
    public void WatchMovie(string name)
    {
        Console.WriteLine("Watching movie on " + name);
    }

    public void DownloadMovie(string name)
    {
        Console.WriteLine("Downloading movie from " + name);
    }
}
class Program
{
    static void Main()
    {
        OTT obj = new OTT();

        obj.WatchMovie("Netflix OTT");
        obj.DownloadMovie("Netflix OTT");

        obj.WatchMovie("Amazon Prime OTT");
        obj.DownloadMovie("Amazon Prime OTT");

        obj.WatchMovie("Disney Plus OTT");
        obj.DownloadMovie("Disney Plus OTT");
    }
}