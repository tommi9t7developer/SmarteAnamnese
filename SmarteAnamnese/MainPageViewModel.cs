using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarteAnamnese
{
    public partial class MainPageViewModel : ObservableObject
    {

        [ObservableProperty]
        string vorname;
        [ObservableProperty]
        string nachname;
        [ObservableProperty]
        DateTime geburtsdatum;

        // Neue Eigenschaft, die überprüft, ob alle Felder ausgefüllt sind
        public bool CanExecuteGoToAnamnese =>
            !string.IsNullOrWhiteSpace(Vorname) &&
            !string.IsNullOrWhiteSpace(Nachname) &&
            Geburtsdatum != default;

        // Der Befehl wird aktualisiert, um CanExecute zu berücksichtigen
        [RelayCommand(CanExecute = nameof(CanExecuteGoToAnamnese))]
        public async Task GoToAnamneseSelectPage()
        {
            // Navigiere zur AnamneseSelectPage
            await Shell.Current.GoToAsync(nameof(AnamneseSelectPage));
        }

        // NotifyPropertyChanged bei Änderungen an den relevanten Eigenschaften
        partial void OnVornameChanged(string value)
        {
            OnPropertyChanged(nameof(CanExecuteGoToAnamnese));
        }

        partial void OnNachnameChanged(string value)
        {
            OnPropertyChanged(nameof(CanExecuteGoToAnamnese));
        }

        partial void OnGeburtsdatumChanged(DateTime value)
        {
            OnPropertyChanged(nameof(CanExecuteGoToAnamnese));
        }
    }
}
