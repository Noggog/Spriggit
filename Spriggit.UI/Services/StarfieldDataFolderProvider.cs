using Mutagen.Bethesda;
using Mutagen.Bethesda.Environments.DI;
using Noggog;

namespace Spriggit.UI.Services;

public class StarfieldDataFolderProvider
{
    private readonly IDataDirectoryLookup _dataDirectoryLookup;
    private Lazy<DirectoryPath> _starfieldDataFolder;
    
    public DirectoryPath StarfieldDataFolder => _starfieldDataFolder.Value;

    public StarfieldDataFolderProvider(IDataDirectoryLookup dataDirectoryLookup)
    {
        _dataDirectoryLookup = dataDirectoryLookup;
        _starfieldDataFolder = new Lazy<DirectoryPath>(() =>
        {
            return _dataDirectoryLookup.Get(GameRelease.Starfield);
        });
    }
}