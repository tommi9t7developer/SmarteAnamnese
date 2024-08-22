using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarteAnamnese
{
    public partial class MainPageViewModel : ObservableObject
    {

       
        // Der Befehl wird aktualisiert, um CanExecute zu berücksichtigen
        [RelayCommand]
        public async Task GoToPersonalienPage()
        {
            // Navigiere zur AnamneseSelectPage
            await Shell.Current.GoToAsync(nameof(PersonalienPage));
        }
    }
}
