using System.Collections.Generic;
using System.Drawing;

namespace ImageHandling.Plugin;

public class PluginManager
{
    private List<IImagePlugin> plugins;

    public PluginManager()
    {
        plugins = new List<IImagePlugin>();
    }

    public void AddPlugin(IImagePlugin plugin)
    {
        plugins.Add(plugin);
    }

    public void ApplyEffects(Bitmap image, List<(IImagePlugin, object[])> effects)
    {
        foreach (var (plugin, parameters) in effects)
        {
            plugin.ApplyEffect(image, parameters);
        }
    }
}
