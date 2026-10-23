using System;

class Multiple
{
    static void Main()
    {
        Phone myPhone = new Phone();
        myPhone.TakePhoto();
        myPhone.RecordVideo();
        myPhone.Call();
        
    }
}

interface ICamera
{
    void TakePhoto();
}

interface IVideoRecorder
{
    void RecordVideo();
}

interface ICall
{
    void Call();
}

class Phone : ICamera, IVideoRecorder, ICall
{
    public void TakePhoto()
    {
        Console.WriteLine("Taking a photo...");
    }

    public void RecordVideo()
    {
        Console.WriteLine("Recording a video...");
    }

    public void Call()
    {
        Console.WriteLine("Making a call...");
    }
}