using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLStandardSample.ViewModels;

namespace XAMLStandardSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}