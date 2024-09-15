using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Graphics;
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
        public async Task Test()
        {
            if (_dataService.Patient.Anamnese is MagenDarmModel magenDarmAnamnese)
                await Application.Current.MainPage.DisplayAlert(
                    "Alert",
                   magenDarmAnamnese.BeschwerdeZeitraum,  // Display the type
                    "OK"
                );
           
        }

    }
}
