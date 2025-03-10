using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ConceptTest.Pages;

namespace ConceptTest.ViewModels;

public partial class MainViewModel : ObservableObject
{

    public MainViewModel()
    {
        TitleButton = "Click me";
    }

    [ObservableProperty]
    private int _count;
   
    [ObservableProperty]
    private string _titleButton;
  
    [ObservableProperty]
    private string _characters;

    [RelayCommand]
    private void Click()
    {
        Application.Current.Windows.FirstOrDefault()?.Page?.Navigation.PushAsync(new ListPage());
    }

}
