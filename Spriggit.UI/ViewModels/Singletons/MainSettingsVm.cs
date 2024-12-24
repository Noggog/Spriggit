using Noggog;
using Noggog.WPF;
using Spriggit.UI.Settings;

namespace Spriggit.UI.ViewModels.Singletons;

public class MainSettingsVm : ViewModel, ISaveMainSettings
{
    public PathPickerVM StarfieldDataFolderPath { get; } = new();

    public void ReadFrom(MainSettings settings)
    {
        StarfieldDataFolderPath.TargetPath = settings.DataFolders.Starfield ?? string.Empty;
    }

    public void SaveInto(MainSettings settings)
    {
        settings.DataFolders.Starfield = StarfieldDataFolderPath.TargetPath.IsNullOrEmpty() ? null : StarfieldDataFolderPath.TargetPath;
    }
}