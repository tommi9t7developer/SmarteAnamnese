using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarteAnamnese
{
    public partial class FinalPageViewModel : ObservableObject
    {
        private readonly DataService _dataService;

        public FinalPageViewModel(DataService dataService)
        {
            _dataService = dataService;
        }

        [RelayCommand]
        public async void Test()
        {
            // Null-checking the entire object chain
            if (_dataService?.Patient?.Anamnese?.Typ != null)
            {
                // If everything is fine, show the alert with the Anamnese Typ
                await Application.Current.MainPage.DisplayAlert(
                    "Alert",
                    _dataService.Patient.Anamnese.ToString(),  // Display the type
                    "OK"
                );
            }
            else
            {
                // If something is null, notify the user or log for debugging
                await Application.Current.MainPage.DisplayAlert(
                    "Alert",
                    "Anamnese type is not available.", // Fallback message
                    "OK"
                );
            }
        }

    }
}
