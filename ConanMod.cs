using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
            this.title = this.GetTitle(this.url).Result;
        }

        public ConanMod(string filePath)
        {
            string[] pathSegments = filePath.Split("\\");
            string[] finalPathSegments = pathSegments[pathSegments.Length - 1].Split("/");
            string modFile = finalPathSegments[1];
            string appIDString = finalPathSegments[0];

            bool result = long.TryParse(appIDString, out this.appID);

            if (!result)
                throw new Exceptions.InvalidConanModPathException("AppID couldn't be found. Improper path format.");

            this.title = modFile.Replace(".pak", "");
            this.url = WORKSHOP_TEMPLATE + this.appID.ToString();
        }

        public override bool Equals(object obj) => this.Equals(obj as ConanMod);

        public bool Equals(ConanMod mod)
        {
            if (ReferenceEquals(this, mod))
                return true;

            if (this.GetType() != mod.GetType())
                return false;

            return this.appID == mod.appID;
        }

        public static bool operator ==(ConanMod lhs, ConanMod rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                    return true;
                return false;
            }
            return lhs.Equals(rhs);
        }

        public static bool operator !=(ConanMod lhs, ConanMod rhs) => !(lhs == rhs);

        private async Task<string> GetTitle(string url)
        {
            HttpClient client = new();
            string content = "Unset";
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    content = await client.GetStringAsync(url);
                    break;
                }
                catch (Exception ex)
                {
                    content = "<title>504 Bad Gateway</title>";
                }
            }
            Regex x = new Regex("<title>(.*)</title>");
            Match m = x.Match(content);

            string temp_title = m.Value.Replace("<title>", "");
            temp_title = temp_title.Replace("</title>", "");

            return temp_title.Replace("Steam Workshop::", "");
        }

        public async Task SetOnlineTitle()
        {
            this.title = await this.GetTitle(this.url);
        }
    }
}
