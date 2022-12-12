using metric_ui.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace metric_ui.ViewModels
{
    public class MainViewModel
    {
        private readonly MetricScrapperService scrapperService;

        public MainViewModel(MetricScrapperService scrapperService)
        {
            this.scrapperService = scrapperService;
            ScrapCommand = new Command(
            execute: () =>
            {
                scrapperService.Scrap("http://localhost:1234/metrics");
            },
            canExecute: () =>
            {
                return true;
            });
        }

        public ICommand ScrapCommand { private set; get; } 
    }
}
