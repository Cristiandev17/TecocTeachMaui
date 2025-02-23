using System.Windows.Input;
using ConceptTest.Pages;

namespace ConceptTest.ViewModels;

public class ListViewModel
{
   public ICommand ClickCommand { get { return new Command(Click); } }

    private void Click()
    {
       
        var winds = Application.Current.Windows.FirstOrDefault()?.Page;
        winds.Navigation.PushAsync(new OtherPage());
    }
}
