using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarteAnamnese
{
    public partial class MainPageViewModel : ObservableObject
    {
        private readonly DataService _dataService;

        public MainPageViewModel(DataService dataService)
        {
            _dataService = dataService;
        }

        [ObservableProperty]
        string sprache;

        // Eine ObservableCollection für die Sprachenliste
        public ObservableCollection<string> SprachenListe { get; } = new ObservableCollection<string>
        {
            "Deutsch",
            "Englisch",
            "Arabisch"
        };


        // Der Befehl wird aktualisiert, um CanExecute zu berücksichtigen
        [RelayCommand]
        public async Task GoToPersonalienPage()
        {
            _dataService.Patient = new Patient(Sprache);

            // Navigiere zur AnamneseSelectPage
            await Shell.Current.GoToAsync(nameof(PersonalienPage));
        }
    }
}
