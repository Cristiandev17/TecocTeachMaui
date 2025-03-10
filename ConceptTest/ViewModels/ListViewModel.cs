using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ConceptTest.Models;

namespace ConceptTest.ViewModels
{
    public partial class ListViewModel : ObservableObject
    {
        public ListViewModel()
        {
            Nombres = new ObservableCollection<PersonModel>
            {
                new PersonModel{ Name = "Daniel", Age = 17, LastName = "Gomez"},
                new PersonModel{ Name = "Joahn", Age = 21, LastName = "Arias"},
                 new PersonModel{ Name = "Juan", Age = 27, LastName = "Jimenez"},

            };
        }


        [ObservableProperty]
        private ObservableCollection<PersonModel> _nombres;

        [RelayCommand]
        public async void Go(PersonModel parameter)
        {
            // var toast = Toast.Make($" Hola {parameter.Name} {parameter.LastName}", CommunityToolkit.Maui.Core.ToastDuration.Long, 25);
            // await toast.Show();

            var snackbar = Snackbar.Make($"{parameter.Name} {parameter.LastName}", actionButtonText: "Mostrar", action: () => Show(parameter), duration: TimeSpan.FromSeconds(3));
            await snackbar.Show();
        }

        private void Show(PersonModel value)
        {
            value.IsShow = true;
        }
    }
}