using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            Dictionary<string, string> d = new Dictionary<string, string>();

            var typeRegex = new Regex(@"(^\S TYPE(.*) (.*)$)");
            var helpRegex = new Regex(@"^\\S HELP (.*) (.*)$");
            foreach (var line in result.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                var r = typeRegex.Match(line);
                if (r.Success)
                {
                    d[r.Groups[2].Value] = r.Groups[3].Value; 
                }

            }
        }
    }
}
