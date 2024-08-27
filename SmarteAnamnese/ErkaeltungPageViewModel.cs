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
        private readonly DataService _dataService;
        private ErkaeltungModel erkaeltung;
        public ErkaeltungPageViewModel(DataService dataService)
        {
            _dataService = dataService;
            erkaeltung = new ErkaeltungModel();
        }

        [ObservableProperty]
        string beschwerdeZeitraum;
       
        [RelayCommand]
        public async Task  SaveErkaeltung()
        {
            erkaeltung.BeschwerdeZeitraum = BeschwerdeZeitraum;
            await Application.Current.MainPage.DisplayAlert("Titel", erkaeltung.BeschwerdeZeitraum, "OK");
        }

        [RelayCommand]
        public async Task GoToMainPage()
        {
                await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
