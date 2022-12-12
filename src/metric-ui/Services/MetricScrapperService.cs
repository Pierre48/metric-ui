using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metric_ui.Services
{
    public class MetricScrapperService
    {
        public async void Scrap(string url)
        {
            using HttpClient client = new();
            var response = await client.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();

            foreach (var line in result.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
            { 
                
            }
        }
    }
}
