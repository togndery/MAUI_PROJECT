using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPP.ViewModel
{
    [QueryProperty("Text","Text")]
    public partial class DetailsPageViewModel:ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task GoBack()
        {
          await Shell.Current.GoToAsync("..");
        }
    }
}
