using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Initializing Gallery View ---\n");

        IViewerImage profilePic = new ImageProxy("https://server.com/users/avatar.png");
        IViewerImage backgroundBanner = new ImageProxy("https://server.com/assets/hero-bg.jpg");

        Console.WriteLine("User scrolled to Profile Picture (1st request):");
        profilePic.RenderImage();

        Console.WriteLine("\nUser refreshed Profile Picture (2nd request):");
        profilePic.RenderImage();

        Console.WriteLine("\nUser scrolled to Background Banner (1st request):");
        backgroundBanner.RenderImage();
    }
}