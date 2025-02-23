using System.ComponentModel;
using System.Windows.Input;
using ConceptTest.Pages;

namespace ConceptTest.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{

    private readonly NavigationPage _navigation;

    public MainViewModel()
    {
        _navigation = Startup.ServiceProvider?.GetService<NavigationPage>();
        TitleButton = "Click me";
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private int _count;
    public int Count
    {
        get { return _count; }
        set
        {
            _count = value;
            OnPropertyChanged(nameof(Count));
        }
    }

    private string _titleButton;
    public string TitleButton
    {
        get { return _titleButton; }
        set
        {
            _titleButton = value;
            OnPropertyChanged(nameof(TitleButton));
        }
    }


    public ICommand ClickCommand { get { return new Command(Click); } }

    private void Click()
    {
        Count++;
        if (Count == 1)
            TitleButton = $"Clicked {Count} time";
        else
            TitleButton = $"Clicked {Count} times";

        //_navigation.PushAsync(new ListPage());

        var winds = Application.Current.Windows.FirstOrDefault()?.Page;
        winds.Navigation.PushAsync(new ListPage());
    }

}
