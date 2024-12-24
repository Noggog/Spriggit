using System.Windows.Input;
using Noggog.WPF;
using ReactiveUI;

namespace Spriggit.UI.ViewModels.Singletons;

public class MainVm : ViewModel
{
    public MainSettingsVm MainSettingsVm { get; }
    public ActivePanelVm ActivePanelVm { get; }
    
    public ICommand OpenGlobalSettingsCommand { get; }

    public MainVm(
        MainSettingsVm mainSettingsVm,
        ReposListingVm reposListingVm,
        ActivePanelVm activePanelVm)
    {
        MainSettingsVm = mainSettingsVm;
        ActivePanelVm = activePanelVm;
        ActivePanelVm.SetMainVm(this);
        activePanelVm.Focus(reposListingVm);
        OpenGlobalSettingsCommand = ReactiveCommand.Create(() =>
        {
            activePanelVm.Focus(mainSettingsVm);
        });
    }
    
    public void Load()
    {
        
    }

    public void Init()
    {
        
    }
}