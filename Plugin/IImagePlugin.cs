using System.Drawing;

namespace ImageHandling.Plugin;

public interface IImagePlugin
{
    string Name { get; }
    void ApplyEffect(Bitmap image, params object[] parameters);
}
