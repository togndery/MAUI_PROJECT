using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPP.ViewModel
{
    public partial class MainVIewModel :ObservableObject
    {
        private readonly IConnectivity _connectivity;
        public MainVIewModel(IConnectivity connectivity)
        {
            Items = new ObservableCollection<string>();
            _connectivity = connectivity;
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
         string text;
       

        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrEmpty(Text))
                return;

            if(_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                
                await Shell.Current.DisplayAlert("Uh Oh", "Not Network Access","OK");
                return;
            }

            Items.Add(Text);
            //Add Item
            Text = String.Empty;
        }

        [RelayCommand]
        void Delete(string itemname)
        {
            if (items.Contains(itemname))
            {
                Items.Remove(itemname);
            }
        }

        [RelayCommand]
        async Task Tap(string itemname)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}?Text={itemname}");
        }
       
    }
}
