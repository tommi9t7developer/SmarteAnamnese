using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarteAnamnese
{
    public partial class AnamneseSelectPageViewModel
    {
        [RelayCommand]
        public async Task GoToErkaeltungPage()
        {
            // Navigiere zur ErkältungsAnamnesePage
            await Shell.Current.GoToAsync(nameof(ErkaeltungPage));
        }
    }
}
