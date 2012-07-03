using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace IDikit.Core.Services
{
    public class WebRequest: IWebRequest
    {
        public string GetTitle(string url)
        {
            var webClient = new WebClient();
            string source = webClient.DownloadString(url);

            string title = Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;

            return title;
        }
    }
}
