using metric_ui.Services;
using metric_ui.ViewModels;

namespace metric_ui
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel viewModel)
        {
            BindingContext = viewModel;

            InitializeComponent();
        }
    }
}