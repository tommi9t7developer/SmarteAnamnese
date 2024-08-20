using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SmarteAnamnese
{
    public partial class ErkaeltungPageViewModel : ObservableObject
    { 
        [ObservableProperty]
        string beschwerdeZeitraum;
       
        [RelayCommand]
        public async Task  SaveErkaeltung()
        {
            ErkaeltungModel erkaeltung = new(beschwerdeZeitraum);
            await Application.Current.MainPage.DisplayAlert("Titel", erkaeltung.BeschwerdeZeitraum, "OK");
        }

        [RelayCommand]
        public async Task GoToMainPage()
        {
                await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
