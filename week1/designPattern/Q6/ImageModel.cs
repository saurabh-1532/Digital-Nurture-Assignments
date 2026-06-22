using System;
using System.Threading;

public class RemoteImage : IViewerImage
{
    private string sourceUrl;

    public RemoteImage(string sourceUrl)
    {
        this.sourceUrl = sourceUrl;
        FetchFromNetwork();
    }

    private void FetchFromNetwork()
    {
        Console.WriteLine($"[Network] Downloading heavy asset from: {sourceUrl}...");
        Thread.Sleep(1500);
        Console.WriteLine($"[Network] Download complete.");
    }

    public void RenderImage()
    {
        Console.WriteLine($"Displaying graphic to UI: {sourceUrl}");
    }
}

public class ImageProxy : IViewerImage
{
    private string targetUrl;
    private RemoteImage cachedImage;

    public ImageProxy(string targetUrl)
    {
        this.targetUrl = targetUrl;
    }

    public void RenderImage()
    {
        if (cachedImage == null)
        {
            cachedImage = new RemoteImage(targetUrl);
        }
        else
        {
            Console.WriteLine("[Cache] Image retrieved directly from local memory.");
        }

        cachedImage.RenderImage();
    }
}