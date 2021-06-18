using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConanExilesModlistManager
{
    class ConanMod
    {
        public const int CONAN_APPID = 440900;
        public const string WORKSHOP_TEMPLATE = "https://steamcommunity.com/sharedfiles/filedetails/?id=";

        public string title;
        public string url;
        public long appID;

        public ConanMod(long appID)
        {
            this.appID = appID;
            this.url = WORKSHOP_TEMPLATE + appID.ToString();
            this.title = this.GetTitle(this.url).Replace("Steam Workshop::", "");
        }

        private string GetTitle(string url)
        {
            WebClient wc = new WebClient();
            string content = wc.DownloadString(url);

            Regex x = new Regex("<title>(.*)</title>");
            Match m = x.Match(content);

            string temp_title = m.Value.Replace("<title>", "");
            temp_title = temp_title.Replace("</title>", "");

            return temp_title;
        }
    }
}
