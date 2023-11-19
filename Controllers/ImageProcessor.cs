using ImageHandling.Plugin;
using System.Drawing;

namespace ImageHandling.Controllers;

public class ImageProcessor
{
    private PluginManager pluginManager;

    public ImageProcessor()
    {
        pluginManager = new PluginManager();
    }

    public void AddPlugin(IImagePlugin plugin)
    {
        pluginManager.AddPlugin(plugin);
    }

    public void ProcessImages(List<(Bitmap, List<(IImagePlugin, object[])>)> imagesWithEffects)
    {
        foreach (var (image, effects) in imagesWithEffects)
        {
            pluginManager.ApplyEffects(image, effects);
        }
    }
}
