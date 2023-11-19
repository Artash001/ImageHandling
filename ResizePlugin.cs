using ImageHandling.Plugin;
using System;
using System.Drawing;

namespace ImageHandling;

public class ResizePlugin : IImagePlugin
{
    public string Name => "Resize";

    public void ApplyEffect(Bitmap image, params object[] parameters)
    {
        int newSize = (int)parameters[0];
    }
}
