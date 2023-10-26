using Mutagen.Bethesda.Serialization.Customizations;

namespace Spriggit.Json.Fallout4;

public class Customization : ICustomize
{
    public void Customize(ICustomizationBuilder builder)
    {
        builder.FilePerRecord();
    }
}