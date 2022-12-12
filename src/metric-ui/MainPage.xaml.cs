using AndroidX.Lifecycle;
using metric_ui.Services;

namespace metric_ui
{
    public partial class MainPage : ContentPage
    {
        private readonly MetricScrapperService scrapperService;

        public MainPage()
        {
            BindingContext = viewModel;

            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            scrapperService.Scrap("http://localhost:1234/metrics");
        }
    }
}